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
    public partial class Overdue : Form
    {
        public Overdue()
        {
            InitializeComponent();
            listView1.Items.AddRange(GenerateListViewItems());
        }
        private ListViewItem[] GenerateListViewItems()
        {
            // Get orders not returned
            List<Order> onRentOrders =
                Model.ordersList.FindAll(order => (order.DateReturned == default(DateTime) && 
                    (DateTime.Now - order.DateRented).TotalDays > 3) && 
                    order.GetType() != typeof(ReserveOrder)).ToList();

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
