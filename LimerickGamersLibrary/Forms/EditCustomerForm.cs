using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class EditCustomerForm : Form
    {
        public EditCustomerForm()
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

        private void customerListView_DoubleClick(object sender, EventArgs e)
        {
            // Check if any item is selected and return if no items
            if (editCustomerListView.SelectedItems == null)
                return;
            else
            {
                MessageBox.Show("Showing Customer file for Customer ID:" + editCustomerListView.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            if (editCustomerListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Customer");
                return;
            }
            // Get selected Id:
            string customerId = editCustomerListView.SelectedItems[0].SubItems[0].Text;
            // Get selected Customer:
            Customer selectedCustomer = Model.customerList.Find(customer => customer.CustomerId == customerId);
            // Construct and show confirmation dialog
            CustomerEditForm editForm = new CustomerEditForm(ref selectedCustomer);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                // Store index of modified Customer
                int index = Model.customerList.FindIndex(customer => customer.CustomerId == customerId);
                // Remove this Customer
                Model.customerList.RemoveAll(customer => customer.CustomerId == customerId);
                // Insert new updated Customer into customereList
                Model.customerList.Insert(index, selectedCustomer);
            }
        }

        private void editCustomerListView_DoubleClick(object sender, EventArgs e)
        {
            editCustomerButton_Click(sender, e);
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (editCustomerListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an Customer");
                return;
            }
            // Get selected Id:
            string customerId = editCustomerListView.SelectedItems[0].SubItems[0].Text;
            // Get selected customer:
            Customer selectedCustomer = Model.customerList.Find(customer => customer.CustomerId == customerId);
            // Construct and show confirmation dialog
            CustomerModifyForm confirmDialog = new CustomerModifyForm(selectedCustomer, "Delete");
            confirmDialog.ShowDialog();

            if (confirmDialog.DialogResult == DialogResult.OK)
            {
                Model.customerList.RemoveAll(customer => customer.CustomerId == customerId);
            }
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.SaveDatabase();
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.LoadDatabase();
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
