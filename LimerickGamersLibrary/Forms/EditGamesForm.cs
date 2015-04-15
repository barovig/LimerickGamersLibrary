using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class EditGamesForm : Form
    {
        public EditGamesForm()
        {
            InitializeComponent();
            // Populates
            PopulateViewFromGamesList(Model.gameList);
            PopulateFilteringOptions();
        }

        private void PopulateViewFromGamesList(List<Game> gamesList)
        {
            editGamesListView.Items.Clear();
            editGamesListView.Items.AddRange(GenerateListViewItems(gamesList));
        }

        private void UpdateListView()
        {
            // Get new games list and populate listview with it
            PopulateViewFromGamesList(FilterGamesList());
        }

        private void PopulateFilteringOptions()
        {
            // Get all distinct Genres
            List<string> genres =
                Model.gameList.GroupBy(game => game.Genre).Select(genre => genre.First().Genre).ToList();
            // Put "All" option at beginning
            genres.Insert(0, "All");
            // Distinct platforms
            List<string> platforms =
                Model.gameList.GroupBy(game => game.Platform).Select(platform => platform.First().Platform).ToList();
            platforms.Insert(0, "All");

            // Devs
            List<string> devs =
                Model.gameList.GroupBy(game => game.Developer).Select(dev => dev.First().Developer).ToList();
            devs.Insert(0, "All");

            // Publishers
            List<string> publishers =
                Model.gameList.GroupBy(game => game.Publisher).Select(pub => pub.First().Publisher).ToList();
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
                    (game.Platform == platformCBox.SelectedValue.ToString() ||
                     platformCBox.SelectedValue.ToString() == "All") &&
                    (game.Developer == devCBox.SelectedValue.ToString() || devCBox.SelectedValue.ToString() == "All") &&
                    (game.Publisher == publCBox.SelectedValue.ToString() || publCBox.SelectedValue.ToString() == "All") &&
                    (game.Year == yearCBox.SelectedValue.ToString() || yearCBox.SelectedValue.ToString() == "All") &&
                    (Enum.GetName(typeof(EsrbRating), game.Rating) == ratingCBox.SelectedValue.ToString() ||
                     ratingCBox.SelectedValue.ToString() == "All")
                    )
                {

                    games.Add(game);

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
            return Model.stockList.Count(stockItem => (stockItem.GameId == gameId && !stockItem.OnRent)).ToString();
            //This LINQ stuff is cool
        }

        // mock function
        private void AddTestGames()
        {
            Model.gameList.Add(new Game("shooter", "superdev", "lousy publisher", "FPS", "PC", "2015", EsrbRating.M));
            Model.gameList.Add(new Game("rpg", "rpgdev", "rpg publisher", "RPG", "XOne", "2014", EsrbRating.E));
            Model.gameList.Add(new Game("indie", "superdev", "rpg publisher", "Action", "PC", "2015", EsrbRating.M));
            Model.gameList.Add(new Game("arcade", "arcade dev", "cool publisher", "Arcade", "PS4", "2013",
                EsrbRating.E10Plus));
            Model.gameList.Add(new Game("shooter", "random dev", "random publisher", "FPS", "XOne", "2015", EsrbRating.A));
            Model.stockList.Add(new StockItem("1"));
            Model.stockList.Add(new StockItem("1"));
            Model.stockList.Add(new StockItem("2"));
            Model.stockList.Add(new StockItem("3", true));

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
            if (editGamesListView.SelectedItems == null)
                return;
            else
            {
                MessageBox.Show("Showing stock items for Game ID:" + editGamesListView.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelSerializer serializer = new ModelSerializer();
            Model.CopyFromSerialized(serializer.DeserializeStatic("database.dat"));
            // Populates
            PopulateViewFromGamesList(Model.gameList);
            PopulateFilteringOptions();
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelSerializer serializer = new ModelSerializer();
            // Default ctor will set sModel contents to contents of static Model
            SerializableModel sModel = new SerializableModel();
            serializer.SerializeStatic("database.dat", sModel);
        }

        private void deleteGameBtn_Click(object sender, EventArgs e)
        {
            if (editGamesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item");
                return;
            }
            // Get selected Id:
            string gameId = editGamesListView.SelectedItems[0].SubItems[0].Text;
            // Get selected game:
            Game selectedGame = Model.gameList.Find(game => game.GameId == gameId);
            // Construct and show confirmation dialog
            GameModifyConfirmDialog confirmDialog = new GameModifyConfirmDialog(selectedGame, "Delete");
            confirmDialog.ShowDialog();

            if (confirmDialog.DialogResult == DialogResult.OK)
            {
                Model.gameList.RemoveAll(game => game.GameId == gameId);
                UpdateListView();
                PopulateFilteringOptions();
            }

        }

        private void editGameBtn_Click(object sender, EventArgs e)
        {
            if (editGamesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item");
                return;
            }
            // Get selected Id:
            string gameId = editGamesListView.SelectedItems[0].SubItems[0].Text;
            // Get selected game:
            Game selectedGame = Model.gameList.Find(game => game.GameId == gameId);
            // Construct and show confirmation dialog
            GameEditForm editForm = new GameEditForm(ref selectedGame);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                // Store index of modified game
                int index = Model.gameList.FindIndex(game => game.GameId == gameId);
                // Remove this game
                Model.gameList.RemoveAll(game => game.GameId == gameId);
                // Insert new updated game into gameList
                Model.gameList.Insert(index, selectedGame);
                UpdateListView();
                PopulateFilteringOptions();
            }
        }

        private void editGamesListView_DoubleClick(object sender, EventArgs e)
        {
            editGameBtn_Click(sender, e);
        }

        private void addGameBtn_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm();
            addGameForm.ShowDialog();
            if (addGameForm.DialogResult == DialogResult.OK)
            {
                UpdateListView();
                PopulateFilteringOptions();
            }
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

        private void loadDatabaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Extension.LoadDatabase();
            // Populates
            PopulateViewFromGamesList(Model.gameList);
            PopulateFilteringOptions();
        }

        private void saveDatabaseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Extension.SaveDatabase();
        }

    }
}
