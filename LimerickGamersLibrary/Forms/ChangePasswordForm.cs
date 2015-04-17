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

namespace LimerickGamersLibrary.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Employee user = Program.LoggedInUser;

            string oldPswd = oldTbox.Text;
            string newPswd = newTbox.Text;
            string newPswd2 = repeatNewTbox.Text;

            if (user.EmployeePswd != oldPswd)
            {
                MessageBox.Show("Incorrect old password");
            }
            else if (newPswd != newPswd2)
            {
                MessageBox.Show("New passwords do not match");
            }
            else
            {
                string empId = Model.employeeList.Find(emp => emp.EmployeePswd == oldPswd).EmployeeId;
                Model.employeeList.Find(emp => emp.EmployeeId == empId).EmployeePswd = newPswd;
                MessageBox.Show("Password Updated!");
                this.Close();
            }

        }

        private void repeatNewTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
                okBtn_Click(sender, e);
        }

        private void newTbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                okBtn_Click(sender, e);
        }
    }
}
