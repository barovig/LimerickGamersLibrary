using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class IssueReservedGameForm : Form
    {
        public IssueReservedGameForm()
        {
            InitializeComponent();
            PopulateViewFromCustomerList(Model.customerList);
        }

        private void PopulateViewFromCustomerList(List<Customer> list)
        {
            customerDetailsList.Items.Clear();
            customerDetailsList.Items.AddRange(GenerateCustomerViewItems());
        }

        private ListViewItem[] GenerateCustomerViewItems()
        {

            // Get reserved Orders
            List<Order> reservedOrders =
                Model.ordersList.FindAll(order => order.GetType() == typeof (ReserveOrder)).ToList();

            ListViewItem[] items = new ListViewItem[reservedOrders.Count];
            int i = 0;

            foreach (var order in reservedOrders)
            {
                string[] orderString = new string[]
                {
                    order.StockItem,
                    Model.customerList.Find(cust => cust.CustomerId == order.CustomerId).Name,
                    Model.customerList.Find(cust => cust.CustomerId == order.CustomerId).Surname,
                    Model.gameList.Find(
                        game => game.GameId == Model.stockList.Find(stock => stock.ItemId == order.StockItem).GameId)
                        .GameName,
                    Model.gameList.Find(
                        game => game.GameId == Model.stockList.Find(stock => stock.ItemId == order.StockItem).GameId)
                        .Platform,

                };
                items[i++] = new ListViewItem(orderString);
            }
            return items;
        }


        private void IssueGameButton_Click(object sender, EventArgs e)
        {
            if (customerDetailsList.SelectedItems.Count == 0) return;

            try
            {
                // Item ID
                string stockId = customerDetailsList.SelectedItems[0].SubItems[0].Text;
                // Get order
                ReserveOrder reserveOrder =
                    (ReserveOrder) Model.ordersList.Find(order => order.StockItem == stockId);
                // Customer ID
                string selectedCustomerId = reserveOrder.CustomerId;
                // Game ID
                string gameId  = Model.stockList.Find(stock => stock.ItemId == stockId).GameId;
                // Create and add new order
                Order issueGame = new Order(selectedCustomerId, stockId, DateTime.Now);
                Model.ordersList.Add(issueGame);
                // Delete currently reserved game
                Model.ordersList.RemoveAll(
                    order => order.CustomerId == selectedCustomerId && order.GetType() == typeof (ReserveOrder));
                // change stock item to OnRent
                Model.stockList.Find(stock => stock.ItemId == stockId).OnRent = true;
                // Create new transaction
                Model.transactList.Add(new Transaction(selectedCustomerId, Fees.RentalFee, DateTime.Now, AccountTransaction.RentalFee));

                ConfirmIssueGame confirmForm =
                    new ConfirmIssueGame(
                        Model.customerList.Find(customer => customer.CustomerId == selectedCustomerId),
                        Model.gameList.Find(game => game.GameId == gameId));
                confirmForm.ShowDialog();

            }
            catch (Exception exc)
            {
                // Do nothing if error happens
                MessageBox.Show("Error: {0}", exc.Message);
            }

        }

    }
}
