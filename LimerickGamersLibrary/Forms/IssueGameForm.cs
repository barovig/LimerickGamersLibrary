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

        private void IssueGameForm_Load(object sender, EventArgs e)
        {

        }

        private void IssueGameButton_Click(object sender, EventArgs e)
        {
            if (GameDetailsLis.SelectedItems.Count == 0 && customerDetailsList.SelectedItems.Count == 0) return;

            // Get selected Customer Id
            string selectedCustomerId = customerDetailsList.SelectedItems[0].SubItems[0].Text;
            // Selected Game Id
            string selectedGameId = GameDetailsLis.SelectedItems[0].SubItems[0].Text;

            string stockId =
            Model.stockList.Find(stock => stock.GameId == selectedGameId && stock.OnRent == false).ItemId;
            Order issueGame = new Order(selectedCustomerId, stockId, DateTime.Now);
            Model.stockList.Find(stock => stock.ItemId == stockId).OnRent = true;
            ConfirmIssueGame confirmForm =
                new ConfirmIssueGame(
                    Model.customerList.Find(customer => customer.CustomerId == selectedCustomerId),
                    Model.gameList.Find(game => game.GameId == selectedGameId));
            confirmForm.ShowDialog();
        }
    }
}
