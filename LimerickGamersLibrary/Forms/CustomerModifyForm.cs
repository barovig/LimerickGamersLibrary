using System;
using System.Drawing;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class CustomerModifyForm : Form
    {
        public CustomerModifyForm()
        {
            InitializeComponent();
        }

        public CustomerModifyForm(Customer customer, string action)
        {
            // Initialize components first
            InitializeComponent();
            // Set window texts
            this.Text = "Confirm " + action;
            confMsg.Text = action + " -  Customer ID: " + customer.CustomerId;
            confMsg.Location = new Point(this.Width / 2 - confMsg.Width / 2, confMsg.Location.Y);

            ApplyButton.Text = action;
            // Set textboxes to game info
            // Set textboxes to game info
            customerNameTB.Text = customer.Name;
            customerSurnameTB.Text = customer.Surname;
            customerAddressTB.Text = customer.Address;
            customerEmailTB.Text = customer.Email;
            customerMobileTB.Text = customer.PhoneNum;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Customer ?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.DialogResult = dialogResult;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
