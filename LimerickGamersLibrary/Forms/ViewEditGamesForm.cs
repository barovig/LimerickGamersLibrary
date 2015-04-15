using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class ViewEditGamesForm : Form
    {
        public ViewEditGamesForm()
        {
            InitializeComponent();

            // Disable Staff's Menu controls
            if (Program.LoggedInUser is Staff)
            {
                // In Edit dropdown menu
                editGameToolStripMenuItem.DropDownItems.RemoveByKey("gamesLibraryToolStripMenuItem");
                editGameToolStripMenuItem.DropDownItems.RemoveByKey("stockItemsToolStripMenuItem");
                // Disable Report menu
                libraryMenuStrip.Items.RemoveByKey("editGameToolStripMenuItem");
            }

            // Populates
            PopulateViewFromGamesList(Model.gameList);
            PopulateFilteringOptions();

        }

        private void PopulateViewFromGamesList(List<Game> gamesList)
        {
            gamesListView.Items.Clear();
            gamesListView.Items.AddRange(GenerateListViewItems(gamesList));
        }

        private void UpdateListView()
        {
            // Get new games list and populate listview with it
            PopulateViewFromGamesList(FilterGamesList());
        }

        private void PopulateFilteringOptions()
        {
            // Get all distinct Genres
            List<string> genres = Model.gameList.GroupBy(game => game.Genre).Select(genre => genre.First().Genre).ToList();
            // Put "All" option at beginning
            genres.Insert(0, "All");
            // Distinct platforms
            List<string> platforms = Model.gameList.GroupBy(game => game.Platform).Select(platform => platform.First().Platform).ToList();
            platforms.Insert(0, "All");

            // Devs
            List<string> devs = Model.gameList.GroupBy(game => game.Developer).Select(dev => dev.First().Developer).ToList();
            devs.Insert(0, "All");

            // Publishers
            List<string> publishers = Model.gameList.GroupBy(game => game.Publisher).Select(pub => pub.First().Publisher).ToList();
            publishers.Insert(0, "All");

            // Years
            List<string> years = Model.gameList.GroupBy(game => game.Year).Select(year => year.First().Year).ToList();
            years.Insert(0, "All");

            // Ratings are inside enumeration
            // Enum.GetNames returns string array of all enumeration names
            string[] ratingsArray = Enum.GetNames(typeof(EsrbRating));
            // Declare a List<string> 
            List<string> ratings = new List<string>();
            // and assign ratingsArray to it
            ratings.AddRange(ratingsArray);
            ratings.Insert(0, "All");

            // Set DataSources for ComboBoxes
            // Genres
            genreCBox.DataSource = genres;
            // Platforms
            platformCBox.DataSource = platforms;
            // Devs
            devCBox.DataSource = devs;
            // Publishers
            publCBox.DataSource = publishers;
            // Years
            yearCBox.DataSource = years;
            // Ratings
            ratingCBox.DataSource = ratings;
        }

        private List<Game> FilterGamesList()
        {
            List<Game> games = new List<Game>();

            foreach (var game in Model.gameList)
            {
                // One monstrous 'if' - not the most readable solution
                if (
                        (game.Genre == genreCBox.SelectedValue.ToString() || genreCBox.SelectedValue.ToString() == "All") &&
                        (game.Platform == platformCBox.SelectedValue.ToString() || platformCBox.SelectedValue.ToString() == "All") &&
                        (game.Developer == devCBox.SelectedValue.ToString() || devCBox.SelectedValue.ToString() == "All") &&
                        (game.Publisher == publCBox.SelectedValue.ToString() || publCBox.SelectedValue.ToString() == "All") &&
                        (game.Year == yearCBox.SelectedValue.ToString() || yearCBox.SelectedValue.ToString() == "All") &&
                        (Enum.GetName(typeof(EsrbRating), game.Rating) == ratingCBox.SelectedValue.ToString() || ratingCBox.SelectedValue.ToString() == "All")
                    )
                {
                    if (showAllRBtn.Checked)
                    {
                        games.Add(game);
                    }
                    else
                    {
                        if (CalculateGameStock(game.GameId) != "0")
                            games.Add(game);
                    }
                }
            }

            return games;
        }

        // Processes passed List<Game> and returns ListViewItems[] array that can be added to ListViewItemCollection
        private ListViewItem[] GenerateListViewItems(List<Game> gamesList)
        {
            // A range of ListViewItems to add to collection that will be returned
            ListViewItem[] items = new ListViewItem[gamesList.Count];
            // Counter
            int i = 0;
            // For each game in list
            foreach (var game in gamesList)
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

        // Calculates Stock Available based on GameID
        private string CalculateGameStock(string gameId)
        {
            // Count stock items in Model.stockList where gameId = GameID AND item is NOT OnRent
            return Model.stockList.Count(stockItem => (stockItem.GameId == gameId && !stockItem.OnRent)).ToString();    //This LINQ stuff is cool
        }


        private void genreCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prevent error when event is raised before all ComboBoxes are initialized
            if (CheckComboboxes())
                UpdateListView();
        }

        private void platformCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckComboboxes())
                UpdateListView();
        }

        private void devCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckComboboxes())
                UpdateListView();
        }

        private void publCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckComboboxes())
                UpdateListView();
        }

        private void yearCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckComboboxes())
                UpdateListView();
        }

        private void ratingCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckComboboxes())
                UpdateListView();
        }

        private void availableStockRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckComboboxes())
                UpdateListView();
        }

        private void showAllRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckComboboxes())
                UpdateListView();
        }

        private bool CheckComboboxes()
        {
            return genreCBox.SelectedValue != null &&
                   platformCBox.SelectedValue != null &&
                   devCBox.SelectedValue != null &&
                   publCBox.SelectedValue != null &&
                   yearCBox.SelectedValue != null &&
                   ratingCBox.SelectedValue != null;
        }

        private void gamesListView_DoubleClick(object sender, EventArgs e)
        {
            // Check if any item is selected and return if no items
            if (gamesListView.SelectedItems == null)
                return;
            else
            {
                string gameId = gamesListView.SelectedItems[0].SubItems[0].Text;
                ViewEditStock stockForm = new ViewEditStock(gameId);
                stockForm.Show();
            }
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.LoadDatabase();
            // Populates
            PopulateViewFromGamesList(Model.gameList);
            PopulateFilteringOptions();
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.SaveDatabase();
        }

        private void gamesLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditGamesForm editGames = new EditGamesForm();
            this.Hide();
            editGames.ShowDialog();
            //Repopulate views
            PopulateViewFromGamesList(Model.gameList);
            PopulateFilteringOptions();
            // When previous dialog is closed - show this form
            this.Show();
        }

        private void ViewEditGamesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditStock viewStockForm = new ViewEditStock();
            viewStockForm.Show();
        }

        private void stockItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditStock viewStockForm = new ViewEditStock();
            viewStockForm.Show();
        }
    }
}
