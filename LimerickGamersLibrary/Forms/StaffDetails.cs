using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;


namespace LimerickGamersLibrary
{
    public partial class StaffDetails : Form
    {
        public StaffDetails()
        {
            InitializeComponent();
            PopulateViewFromCustomerList(Model.employeeList);
        }

        private void PopulateViewFromCustomerList(List<Employee> EmployeeList)
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(GenerateListViewItems(EmployeeList));
        }

        // Processes passed List<customer> and returns ListViewItems[] array that can be added to ListViewItemCollection
        private ListViewItem[] GenerateListViewItems(List<Employee> EmployeeList)
        {
            // A range of ListViewItems to add to collection that will be returned
            ListViewItem[] items = new ListViewItem[EmployeeList.Count];
            // Counter
            int i = 0;
            // For each customer in list
            foreach (var employee in EmployeeList)
            {
                // Declare customerArray which holds all properties of customer as string[] array
                string[] EmployeeArray = employee.ToStringArray();
                // Declare string[] array item which can hold all fields from customer
                string[] item = new string[EmployeeArray.Count()];
                // Copy everything into item string[] array
                EmployeeArray.CopyTo(item, 0);
                // Add this item array to ListViewItem[] array
                items[i++] = new ListViewItem(item);
            }
            return items;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Employee");
                return;
            }
            // Get selected Id:
            string employeeId = listView1.SelectedItems[0].SubItems[2].Text;
            // Get selected Customer:
            Employee selectedEmployee = Model.employeeList.Find(employee => employee.EmployeeId == employeeId);

            // Construct and show confirmation dialog
            EditStaff editForm = new EditStaff(selectedEmployee);
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                // Store index of modified Customer
                int index = Model.employeeList.FindIndex(employee => employee.EmployeeId == employeeId);
                // Remove this Customer
                Model.employeeList.RemoveAll(employee => employee.EmployeeId == employeeId);
                // Insert new updated Customer into customereList
                Model.employeeList.Insert(index, selectedEmployee);
                PopulateViewFromCustomerList(Model.employeeList);

            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}
