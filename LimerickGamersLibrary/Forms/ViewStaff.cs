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

namespace OoProject
{
    public partial class ViewStaff : Form
    {
        public ViewStaff()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {


            textBox1.Text = " ";
            if (Model.employeeList.Count > 0)
            {
                foreach (Employee employee in Model.employeeList)
                {

                    textBox1.Text += string.Format(employee.showDetails(), System.Environment.NewLine);


                }
            }
            else
            {
                textBox1.Text = "There are no staff";
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
