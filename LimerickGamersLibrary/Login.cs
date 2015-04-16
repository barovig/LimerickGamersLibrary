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
using LimerickGamersLibrary.Forms;

namespace LimerickGamersLibrary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // open database
            bool loaded = Extension.LoadDatabase();

            // If database failed to open, add staff in order to proceed
            if (!loaded)
            {
                MessageBox.Show("Database failed to load. Please log in as \"admin\".");
            }

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (idTbox.Text == "admin")
            {
                InitialManagerForm form = new InitialManagerForm();
                form.ShowDialog();

                return;
            }

            String login = idTbox.Text;
            String password = pswdTbox.Text;
            // Search employees collection 
            foreach (var emplopyee in Model.employeeList)
            {
                // and if found an employee
                if (emplopyee.EmployeeId == login && emplopyee.EmployeePswd == password)
                {
                    // Set LoggedInUser to employee
                    Program.LoggedInUser = emplopyee;
                    // Create and show Main Menu
                    MainMenuForm menuForm = new MainMenuForm(this);
                    this.Hide();
                    // Clear textboxes
                    idTbox.Text = "";
                    pswdTbox.Text = "";
                    menuForm.Show();
                }
            }
            // If LoggedInUser is still null, userId or pswd don't match
            if (Program.LoggedInUser == null)
                MessageBox.Show("Login failed. Enter correct Staff ID and password");
        }

        private void idTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                loginBtn_Click(sender, e);
        }

        private void pswdTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                loginBtn_Click(sender, e);
        }
    }
}
