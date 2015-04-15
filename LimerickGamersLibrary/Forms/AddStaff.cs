using System;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
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
            string id = Model.GenerateEmployeeId().ToString();

            // If manager selected
            if (managerRBtn.Checked)
                Model.employeeList.Add(new Manager(name, lastName, id));
            else
            {
                Model.employeeList.Add(new Staff(name, lastName, id));
            }



            Close();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
