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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTbox.Text;
            string lastName = surnameTbox.Text;
            string address = Address.Text;

            string phonenumber = PhoneNumber.Text;
            string email = Email.Text;

            // If manager selected
            if (managerRBtn.Checked)
                Model.employeeList.Add(new Manager(name, lastName, address, phonenumber, email));
            else
            {
                Model.employeeList.Add(new Staff(name, lastName, address, phonenumber, email));
            }



            Close();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
