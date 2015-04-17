using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class IssueGameForm : Form
    {
        public IssueGameForm()
        {
            InitializeComponent();
            PopulateViewFromCustomerList(Model.customerList);
            PopulateViewFromGamesList(Model.gameList);
        }

        private void PopulateViewFromCustomerList(List<Customer> list)
        {
            customerDetailsList.Items.Clear();
            customerDetailsList.Items.AddRange(GenerateCustomerViewItems(list));
        }
        private void PopulateViewFromGamesList(List<Game> list)
        {
            GameDetailsLis.Items.Clear();
            GameDetailsLis.Items.AddRange(GenerateGameViewItems(list));
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
            // Get all games available
            List<Game> availableGames = Model.gameList.FindAll(
                game => Model.stockList.Any(stock => stock.GameId == game.GameId && stock.OnRent == false))
                .ToList();

            int i = 0;

            ListViewItem[] items = new ListViewItem[availableGames.Count];
            foreach (string[] gameArray in availableGames.Select(game => new string[]
            {
                game.GameId,
                game.GameName,
                game.Platform
            }))
            {
                items[i++] = new ListViewItem(gameArray);
            }
            return items;
        }

        private void IssueGameForm_Load(object sender, EventArgs e)
        {

        }

        private void IssueGameButton_Click(object sender, EventArgs e)
        {
            if (GameDetailsLis.SelectedItems.Count == 0 && customerDetailsList.SelectedItems.Count == 0) return;


            try
            {
                // Get selected Customer Id
                string selectedCustomerId = customerDetailsList.SelectedItems[0].SubItems[0].Text;
                // Selected Game Id
                string selectedGameId = GameDetailsLis.SelectedItems[0].SubItems[0].Text;

                // Check if customer already rented a game
                if (
                    Model.ordersList.Any(
                        order => order.CustomerId == selectedCustomerId && order.DateReturned == default(DateTime)))
                {
                    MessageBox.Show("Selected customer has a game rented. Cannot rent more than one game.");
                    return;
                }

                string stockId =
                    Model.stockList.Find(stock => stock.GameId == selectedGameId && stock.OnRent == false).ItemId;
                // Create and add new order
                Order issueGame = new Order(selectedCustomerId, stockId, DateTime.Now);
                Model.ordersList.Add(issueGame);
                // change stock item to OnRent
                Model.stockList.Find(stock => stock.ItemId == stockId).OnRent = true;
                // Create new transaction
                Model.transactList.Add(new Transaction(selectedCustomerId, Fees.RentalFee, DateTime.Now, AccountTransaction.RentalFee));

                ConfirmIssueGame confirmForm =
                    new ConfirmIssueGame(
                        Model.customerList.Find(customer => customer.CustomerId == selectedCustomerId),
                        Model.gameList.Find(game => game.GameId == selectedGameId));
                confirmForm.ShowDialog();

            }
            catch (Exception)
            {
                // Do nothing if error happens
            }
            
        }
    }
}
