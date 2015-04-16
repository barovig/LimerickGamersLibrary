using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class ViewCustomerForm : Form
    {
        public ViewCustomerForm()
        {
            InitializeComponent();
            PopulateViewFromCustomerList(Model.customerList);
        }

        private void PopulateViewFromCustomerList(List<Customer> customerList)
        {
            editCustomerListView.Items.Clear();
            editCustomerListView.Items.AddRange(GenerateListViewItems(customerList));
        }

        // Processes passed List<customer> and returns ListViewItems[] array that can be added to ListViewItemCollection
        private ListViewItem[] GenerateListViewItems(List<Customer> customerList)
        {
            // A range of ListViewItems to add to collection that will be returned
            ListViewItem[] items = new ListViewItem[customerList.Count];
            // Counter
            int i = 0;
            // For each customer in list
            foreach (var customer in customerList)
            {
                // Declare customerArray which holds all properties of customer as string[] array
                string[] customerArray = customer.ToStringArray();
                // Declare string[] array item which can hold all fields from customer
                string[] item = new string[customerArray.Count()];
                // Copy everything into item string[] array
                customerArray.CopyTo(item, 0);
                // Add this item array to ListViewItem[] array
                items[i++] = new ListViewItem(item);
            }
            return items;
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelSerializer serializer = new ModelSerializer();
            // Default ctor will set sModel contents to contents of static Model
            SerializableModel sModel = new SerializableModel();
            serializer.SerializeStatic("database.dat", sModel);
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelSerializer serializer = new ModelSerializer();
            Model.CopyFromSerialized(serializer.DeserializeStatic("database.dat"));
            // Populates
            PopulateViewFromCustomerList(Model.customerList);
        }

        private void customerLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCustomerForm editCustomer = new EditCustomerForm();
            editCustomer.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomerForm viewEditCustomerForm = new ViewCustomerForm();
            viewEditCustomerForm.Show();
        }

        private void editCustomerListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
