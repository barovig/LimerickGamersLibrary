using System;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class InitialManagerForm : Form
    {
        public InitialManagerForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTbox.Text;
            string lastName = surnameTbox.Text;
            string id = Model.GenerateEmployeeId().ToString();
            Model.employeeList.Add(new Manager(name, lastName, id));
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
