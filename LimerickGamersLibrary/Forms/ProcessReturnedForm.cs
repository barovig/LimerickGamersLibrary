using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class ProcessReturnedForm : Form
    {
        public ProcessReturnedForm()
        {
            InitializeComponent();
            // Populate ListView
            PopulateViewFromOrderList();
            // Disable Return Btn
            returnGameBtn.Enabled = false;
        }

        private void PopulateViewFromOrderList()
        {
            gamesListView.Items.Clear();
            gamesListView.Items.AddRange(GenerateListViewItems());
        }

        private ListViewItem[] GenerateListViewItems()
        {
            // Get orders not returned
            List<Order> onRentOrders =
                Model.ordersList.FindAll(order => order.DateReturned == default(DateTime) &&  order.GetType() != typeof(ReserveOrder)).ToList();

            ListViewItem[] items = new ListViewItem[onRentOrders.Count];
            int i = 0;
            foreach (var order in onRentOrders)
            {
                string[] columns = new string[5];
                // Item ID
                columns[0] = order.StockItem;
                string GameId = Model.stockList.Find(stock => stock.ItemId == order.StockItem).GameId;
                // Game Name
                columns[1] = Model.gameList.Find(game => game.GameId == GameId).GameName;
                // Customer Name
                columns[2] = Model.customerList.Find(cust => cust.CustomerId == order.CustomerId).Name;
                // Customer Surname
                columns[3] = Model.customerList.Find(cust => cust.CustomerId == order.CustomerId).Surname;
                // Date Rented
                columns[4] = order.DateRented.ToShortDateString();
                items[i++] = new ListViewItem(columns);
            }
            return items;
        }

        private void gamesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gamesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (gamesListView.SelectedItems.Count != 0)
                returnGameBtn.Enabled = true;
            else
            {
                returnGameBtn.Enabled = false;
            }
        }

        private void showCustOrdersBtn_Click(object sender, EventArgs e)
        {
            // Get orders not returned i.e. orders with DateReturned set to default
            List<Order> onRentOrders =
                Model.ordersList.FindAll(order => order.DateReturned == default(DateTime)).ToList();

            int i = 0;

            try
            {
                string custName = nameCBox.Text.ToLower();
                string custSurname = surnameCBox.Text.ToLower();

                if (custName == "" || custSurname == "")
                    throw new Exception("Empty Fields");
                // Retrieve customer ID
                string custId = Model.customerList.Find(cust => cust.Name.ToLower() == custName && cust.Surname.ToLower() == custSurname)
                    .CustomerId;
                ListViewItem[] items = new ListViewItem[1];

                foreach (var order in onRentOrders)
                {
                    if (order.CustomerId == custId)
                    {
                        string[] columns = new string[5];
                        // Item ID
                        columns[0] = order.StockItem;
                        string GameId = Model.stockList.Find(stock => stock.ItemId == order.StockItem).GameId;
                        // Game Name
                        columns[1] = Model.gameList.Find(game => game.GameId == GameId).GameName;
                        // Customer Name
                        columns[2] = nameCBox.Text;
                        // Customer Surname
                        columns[3] = surnameCBox.Text;

                        // Date Rented
                        columns[4] = order.DateRented.ToShortDateString();
                        items[i++] = new ListViewItem(columns);
                    }
                }

                gamesListView.Items.Clear();
                gamesListView.Items.AddRange(items);

            }
            catch (Exception exception)
            {
                if(exception.Message == "Empty Fields")
                    MessageBox.Show("Enter both customer Name and Surname.");
                else
                {
                    MessageBox.Show("Error retrieving customer list.");
                }
            }


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameCBox.Text = "";
            surnameCBox.Text = "";

            PopulateViewFromOrderList();

        }

        private void returnGameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Item id:
                string itemId = gamesListView.SelectedItems[0].SubItems[0].Text;
                // Date string
                string rentDateString = gamesListView.SelectedItems[0].SubItems[4].Text;

                // Retrieve order for processing
                Order processOrder = Model.ordersList.Find(
                    order => order.StockItem == itemId && order.DateRented.ToShortDateString() == rentDateString);

                // Get day difference as string
                string dayDiffString = (DateTime.Now - processOrder.DateRented).TotalDays.ToString().Split('.')[0];
                // Parse to int
                int dayDiff = int.Parse(dayDiffString);

                // Create orderInfo List<> here
                List<string> orderInfo = new List<string>();
                foreach (ListViewItem.ListViewSubItem item in gamesListView.SelectedItems[0].SubItems)
                {
                    orderInfo.Add(item.Text);
                }
                // Call confirmation forms 
                ReturnItemConfirmForm returnConfirmForm;

                returnConfirmForm = dayDiff > 3 ? new ReturnItemConfirmForm(orderInfo, dayDiff) : new ReturnItemConfirmForm(orderInfo);

                returnConfirmForm.ShowDialog();

                // Set order to returned if DIALOG RESULT STATUS OK
                if (returnConfirmForm.DialogResult == DialogResult.OK)
                {
                    Model.ordersList.Find(
                        order => order.StockItem == itemId && order.DateRented.ToShortDateString() == rentDateString).DateReturned = DateTime.Now;
                    // Change OnRent to false
                    Model.stockList.Find(stock => stock.ItemId == itemId).OnRent = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select customer.");
            }


            PopulateViewFromOrderList();

        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.LoadDatabase();
            // Populates
            PopulateViewFromOrderList();
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.SaveDatabase();
        }

        private void nameCBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                showCustOrdersBtn_Click(sender, e);
        }

        private void surnameCBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                showCustOrdersBtn_Click(sender, e);
        }
    }
}
