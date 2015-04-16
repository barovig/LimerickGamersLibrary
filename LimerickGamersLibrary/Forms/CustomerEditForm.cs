using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class CustomerEditForm : Form
    {
        public CustomerEditForm(ref Customer customer)
        {
            InitializeComponent();
            // Set label
            confMsg.Text = "Edit Customer -  Customer ID: " + customer.CustomerId;
            // Set label location
            confMsg.Location = new Point(this.Width / 2 - confMsg.Width / 2, confMsg.Location.Y);

            // Set textboxes to game info
            customerNameTB.Text = customer.Name;
            customerSurnameTB.Text = customer.Surname;
            customerAddressTB.Text = customer.Address;
            customerEmailTB.Text = customer.Email;
            customerMobileTB.Text = customer.PhoneNum;

            passedCustomer = customer;
        }
        private Customer passedCustomer;

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apply Changes Made?", "Confirm Edit", MessageBoxButtons.OKCancel);
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
                    // Modify this game
                    passedCustomer.Name = customerNameTB.Text;
                    passedCustomer.Surname = customerSurnameTB.Text;
                    passedCustomer.Address = customerAddressTB.Text;
                    passedCustomer.Email = customerEmailTB.Text;
                    passedCustomer.PhoneNum = customerMobileTB.Text;

                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
