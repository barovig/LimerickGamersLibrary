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
    public partial class DeleteStaff : Form
    {
        public DeleteStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            textBox2.Text = "";
            Employee deletestaff = new Employee();
            bool found = false;
            foreach (var staff in Model.employeeList)
            {
                if (staff.EmployeeId.Equals(name))
                {
                    deletestaff = staff;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                var result = MessageBox.Show(String.Format("Are you sure you want to delete{0}{1}", System.Environment.NewLine, deletestaff.showDetails()), "Are you Sure?",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {

                    Model.employeeList.Remove(deletestaff);
                }
                else
                {
                    // do nothing because the no button was pushed

                }
            }
            else
            {
                textBox2.Text += string.Format("{0}{1}", "No Games Were Found That Match Your Search", System.Environment.NewLine);
            }
        }
    }
}
