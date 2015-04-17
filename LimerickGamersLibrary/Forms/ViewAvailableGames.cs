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
    public partial class ViewAvailableGames : Form
    {
        public ViewAvailableGames()
        {
            AddTestGames();
            InitializeComponent();

        }

        private string CalculateGameStock(string gameId)
        {
            // Count stock items in Model.stockList where gameId = GameID AND item is NOT OnRent
            return Model.stockList.Count(stockItem => (stockItem.GameId == gameId && !stockItem.OnRent)).ToString();    //This LINQ stuff is cool
        }

        private ListViewItem[] GenerateListViewItems(List<Game> gamesList)
        {

            // list to store items available
            List<Game> availableGames = new List<Game>();
            // Counter
            int i = 0;
            // For each game in list
            foreach (var game in gamesList)
            {
                if (int.Parse(CalculateGameStock(game.GameId)) > 0)
                {
                    availableGames.Add(game);
                }
            }
            // A range of ListViewItems to add to collection that will be returned
            ListViewItem[] items = new ListViewItem[availableGames.Count];
            foreach (var game in availableGames)
            {
                // Declare gameArray which holds all properties of game as string[] array
                string[] gameArray = game.ToStringArray();
                // Declare string[] array item which can hold all fields from Game + one field for Available Stock
                string[] item = new string[gameArray.Count() + 1];
                // Declare string[] 1-array (required for CopyTo() method) and fill it with value returned by CalculateGameStock() that
                // returns the number of stock items available for given game
                string[] availableStock = new string[1] { CalculateGameStock(game.GameId) };
                // Copy everything into item string[] array
                gameArray.CopyTo(item, 0);
                availableStock.CopyTo(item, gameArray.Length);
                // Add this item array to ListViewItem[] array
                items[i++] = new ListViewItem(item);
            }
            return items;
        }
        private void PopulateViewFromGamesList(List<Game> gamesList)
        {
            listView1.Items.AddRange(GenerateListViewItems(gamesList));
        }

        private void AddTestGames()
        {

        }

        private void gamesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(GenerateListViewItems(Model.gameList));
        }
    }
}
