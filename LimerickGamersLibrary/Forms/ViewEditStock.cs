using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class ViewEditStock : Form
    {
        public ViewEditStock()
        {
            InitializeComponent();
            // Populates
            PopulateViewFromGamesList(Model.gameList);
            PopulateViewFromStockList(Model.stockList);
            // Disable Staff Controls
            if (Program.LoggedInUser is Staff)
            {
                addStockItemBtn.Hide();
                deleteStockItemBtn.Hide();
                toggleRentBtn.Hide();
                // In Edit dropdown menu
                editGameToolStripMenuItem.DropDownItems.RemoveByKey("gamesLibraryToolStripMenuItem");
                editGameToolStripMenuItem.DropDownItems.RemoveByKey("stockItemsToolStripMenuItem");
                // Disable Report menu
                viewStockMenuStrip.Items.RemoveByKey("editGameToolStripMenuItem");
            }
            // Disable button initially
            addStockItemBtn.Enabled = false;
            deleteStockItemBtn.Enabled = false;
            toggleRentBtn.Enabled = false;
        }

        public ViewEditStock(string gameId)
            : this()
        {
            // Select game at gameId
            int index = 0;
            for (int i = 0; i < gamesListView.Items.Count; i++)
            {
                if (gamesListView.Items[i].Text == gameId)
                {
                    index = i;
                    break;
                }
            }
            gamesListView.Items[index].Selected = true;
            gamesListView_SelectedIndexChanged(new object(), new EventArgs());

        }

        private void PopulateViewFromGamesList(List<Game> gamesList)
        {
            gamesListView.Items.Clear();
            gamesListView.Items.AddRange(GenerateListViewItems(gamesList));
        }

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
                // Add this item array to ListViewItem[] array
                items[i++] = new ListViewItem(gameArray);
            }
            return items;
        }

        private void PopulateViewFromStockList(List<StockItem> stockList)
        {
            stockItemsListView.Items.Clear();
            stockItemsListView.Items.AddRange(GenerateStockListViewItems(stockList));
        }

        private ListViewItem[] GenerateStockListViewItems(List<StockItem> stockList)
        {
            // A range of ListViewItems to add to collection that will be returned
            ListViewItem[] items = new ListViewItem[stockList.Count];
            // Counter
            int i = 0;
            // For each game in list
            foreach (var item in stockList)
            {
                // Declare gameArray which holds all properties of game as string[] array
                string[] stockArray = item.ToStringArray();
                // Add this item array to ListViewItem[] array
                items[i++] = new ListViewItem(stockArray);
            }
            return items;

        }

        private void addStockItemBtn_MouseHover(object sender, EventArgs e)
        {
            viewStockToolStrip.Text = "Add item to stock for selected game.";
        }

        private void addStockItemBtn_MouseLeave(object sender, EventArgs e)
        {
            viewStockToolStrip.Text = "Select game to view its stock.";
        }

        private void gamesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected and return if no items
            if (gamesListView.SelectedItems.Count == 0)
            {
                PopulateViewFromStockList(Model.stockList);
                addStockItemBtn.Enabled = false;
            }
            else
            {
                // Get selected item Id
                string selectedGameId = gamesListView.SelectedItems[0].SubItems[0].Text;
                // Find all items for selected game
                List<StockItem> gameStock = Model.stockList.FindAll(stockItem => stockItem.GameId == selectedGameId);
                PopulateViewFromStockList(gameStock);
                addStockItemBtn.Enabled = true;
            }
        }

        private void stockItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if any item is selected and return if no items
            if (stockItemsListView.SelectedItems.Count != 0)
            {
                deleteStockItemBtn.Enabled = true;
                toggleRentBtn.Enabled = true;
            }
            else
            {
                deleteStockItemBtn.Enabled = false;
                toggleRentBtn.Enabled = false;
            }

        }

        private void addStockItemBtn_Click(object sender, EventArgs e)
        {
            // Get selected game Id
            string selectedGameId = gamesListView.SelectedItems[0].SubItems[0].Text;
            // Add new stock item
            StockItem newStockItem = new StockItem(selectedGameId);
            Model.stockList.Add(newStockItem);
            //Repopulate Stock List
            List<StockItem> gameStock = Model.stockList.FindAll(stockItem => stockItem.GameId == selectedGameId);
            PopulateViewFromStockList(gameStock);
            stockItemsListView.Select();
        }

        private void deleteStockItemBtn_Click(object sender, EventArgs e)
        {
            if (stockItemsListView.SelectedItems.Count == 0 || stockItemsListView.Items.Count == 0)
                return;
            // Get selected item Id
            string selectedItemId = stockItemsListView.SelectedItems[0].SubItems[0].Text;
            // Selected item index
            int selectionIndex = stockItemsListView.SelectedIndices[0];
            // Select previous item if not first item
            selectionIndex = selectionIndex == 0 ? selectionIndex : selectionIndex - 1;

            // remove from stockList
            Model.stockList.RemoveAll(item => item.ItemId == selectedItemId);
            // repopulate stock list
            // If no games selected
            if (gamesListView.SelectedItems.Count == 0)
            {
                PopulateViewFromStockList(Model.stockList);
            }
            else
            {
                // Get selected game Id
                string selectedGameId = gamesListView.SelectedItems[0].SubItems[0].Text;
                List<StockItem> gameStock = Model.stockList.FindAll(stockItem => stockItem.GameId == selectedGameId);
                PopulateViewFromStockList(gameStock);
            }

            if (stockItemsListView.Items.Count != 0)
            {
                stockItemsListView.Items[selectionIndex].Selected = true;
                stockItemsListView.Select();
            }
        }

        private void deleteStockItemBtn_MouseHover(object sender, EventArgs e)
        {
            viewStockToolStrip.Text = "Delete selected stock item.";
        }

        private void deleteStockItemBtn_MouseLeave(object sender, EventArgs e)
        {
            viewStockToolStrip.Text = "Select game to view its stock.";
        }

        private void toggleRentBtn_MouseHover(object sender, EventArgs e)
        {
            viewStockToolStrip.Text = "Toggle rent status for selected stock item.";
        }

        private void toggleRentBtn_MouseLeave(object sender, EventArgs e)
        {
            viewStockToolStrip.Text = "Select game to view its stock.";
        }

        private void toggleRentBtn_Click(object sender, EventArgs e)
        {
            if (stockItemsListView.SelectedItems.Count == 0)
                return;

            // Get selected item Id
            string selectedItemId = stockItemsListView.SelectedItems[0].SubItems[0].Text;
            // Selected item index
            int selectionIndex = stockItemsListView.SelectedIndices[0];

            Model.stockList.Find(stockItem => stockItem.ItemId == selectedItemId).ToggleRent();
            // Repopulate listView
            if (gamesListView.SelectedItems.Count == 0)
            {
                PopulateViewFromStockList(Model.stockList);
                stockItemsListView.Items[selectionIndex].Selected = true;
                stockItemsListView.Select();
            }
            else
            {
                // Get selected game Id
                string selectedGameId = gamesListView.SelectedItems[0].SubItems[0].Text;
                List<StockItem> gameStock = Model.stockList.FindAll(stockItem => stockItem.GameId == selectedGameId);
                PopulateViewFromStockList(gameStock);
                stockItemsListView.Items[selectionIndex].Selected = true;
                stockItemsListView.Select();
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void stockItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void gamesLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.LoadDatabase();
            // Populates
            PopulateViewFromGamesList(Model.gameList);
            PopulateViewFromStockList(Model.stockList);
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.SaveDatabase();
        }

        private void stockItemsListView_MouseEnter(object sender, EventArgs e)
        {
            viewStockToolStrip.Text = "Select stock item to edit or delete it.";
        }

        private void stockItemsListView_MouseLeave(object sender, EventArgs e)
        {
            viewStockToolStrip.Text = "Select game to view its stock.";
        }
    }
}
