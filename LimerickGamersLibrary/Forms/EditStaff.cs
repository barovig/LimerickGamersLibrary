using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary
{
    public partial class EditStaff : Form
    {
        public EditStaff()
        {
            InitializeComponent();

        }
        public EditStaff(Employee employee)
        {
            InitializeComponent();
            // Set window texts


            label1.Location = new Point(this.Width / 2 - label1.Width / 2, label1.Location.Y);


            FirstName.Text = employee.Name;
            LastName.Text = employee.Surname;
            Address.Text = employee.Address;
            phoneNumber.Text = employee.PhoneNum;
            Email.Text = employee.Email;
            passedStaff = employee;


            // Initialize components first


        }
        private Employee passedStaff;
        private void editstaff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Delete Customer ?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                if (
                             FirstName.Text == "" ||
                  LastName.Text == "" ||
                   Address.Text == "" ||
                   phoneNumber.Text == "" ||
                   Email.Text == ""
                   )
                {
                    MessageBox.Show("Please fill all fields.");
                }
                else
                {
                    // Modify this game
                    passedStaff.Name = FirstName.Text;
                    passedStaff.Surname = LastName.Text;
                    passedStaff.Address = Address.Text;
                    passedStaff.Email = phoneNumber.Text;
                    passedStaff.PhoneNum = Email.Text;

                    this.DialogResult = DialogResult.OK;
                }


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
