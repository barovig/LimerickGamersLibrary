using LimerickGamersLibrary.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimerickGamersLibrary
{
    public partial class ReserveID : Form
    {
        public ReserveID()
        {
            InitializeComponent();
            PopulateViewFromCustomerList(Model.customerList);
            PopulateViewFromGamesList(Model.gameList);
        }

        private void PopulateViewFromCustomerList(List<Customer> list)
        {
            listView2.Items.Clear();
            listView2.Items.AddRange(GenerateCustomerViewItems(list));
        }
        private void PopulateViewFromGamesList(List<Game> list)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(GenerateGameViewItems(list));
        }

        private ListViewItem[] GenerateCustomerViewItems(List<Customer> customerList)
        {
            ListViewItem[] items = new ListViewItem[customerList.Count];
            int i = 0;
            foreach (string[] customerArray in customerList.Select(cust => new string[]
            {
                // Customer ID
                cust.CustomerId,
                // Customer Name
                Model.customerList.Find(customer => customer.CustomerId == cust.CustomerId).Name,
                // Customer Surname
                Model.customerList.Find(customer => customer.CustomerId == cust.CustomerId).Surname,
            }))
            {
                // Add ListItem created from string[] array to collection of items
                items[i++] = new ListViewItem(customerArray);
            }
            return items;
        }

        private ListViewItem[] GenerateGameViewItems(List<Game> gameList)
        {
            ListViewItem[] items = new ListViewItem[gameList.Count];
            int i = 0;
            foreach (string[] gameArray in gameList.Select(games => new string[]
            {
                // Transaction ID
                games.GameId,
                // Customer Name
                Model.gameList.Find(game => game.GameId == games.GameId).GameName,
                // Customer Surname
                Model.gameList.Find(game => game.GameId == games.GameId).Platform,
                // Amount
            }))
            {
                // Add ListItem created from string[] array to collection of items
                items[i++] = new ListViewItem(gameArray);
            }
            return items;
        }


        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0 && listView2.SelectedItems.Count == 0) return;

            try
            {
                string selectedCustomerId = listView2.SelectedItems[0].SubItems[0].Text;

                string selectedGameId = listView1.SelectedItems[0].SubItems[0].Text;

                if (
                    Model.ordersList.Any(
                        order => order.CustomerId == selectedCustomerId && order.DateReturned == default(DateTime)))
                {
                    MessageBox.Show("Cannon rent/reserve more than one item.");
                    return;
                }

                string stockId =
                Model.stockList.Find(stock => stock.GameId == selectedGameId && stock.OnRent == false).ItemId;
                ReserveOrder game = new ReserveOrder(DateTime.Now, selectedCustomerId, stockId);
                Model.stockList.Find(stock => stock.ItemId == stockId).OnRent = true;
                Model.ordersList.Add(game);
            }
            catch (Exception)
            {
                // Do nothing
            }
           

        }
    }
}
