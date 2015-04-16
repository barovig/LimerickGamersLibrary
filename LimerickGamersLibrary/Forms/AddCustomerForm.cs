using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Class
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();

            // Set label location
            confMsg.Location = new Point(this.Width / 2 - confMsg.Width / 2, confMsg.Location.Y);
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Add Customer ?", "Confirm Add", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                // Check for empty inputs
                if (
                    customerNameTB.Text == "" ||
                    customerSurnameTB.Text == "" ||
                    customerAddressTB.Text == "" ||
                    customerEmailTB.Text == "" ||
                    customerMobileTB.Text == ""
                    )
                {
                    MessageBox.Show("Please fill all fields.");
                }
                else
                {

                    Customer newCustomer = new Customer(customerNameTB.Text, customerSurnameTB.Text, customerAddressTB.Text, customerEmailTB.Text, customerMobileTB.Text);
                    // Modify this game
                    Model.customerList.Add(newCustomer);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
