using System;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;
using OoProject;

namespace LimerickGamersLibrary.Forms
{
    public partial class MainMenuForm : Form
    {
        private Form LoginForm { set; get; }

        public MainMenuForm(Form parent)
        {
            // set parent form (login) reference
            LoginForm = parent;

            InitializeComponent();
            // Assign label to username
            signedInLabel.Text = Program.LoggedInUser.Name.ToString();
            
            // Disable/Enable Staff's Menu controls
            if (Program.LoggedInUser is Staff)
            {
                //Set management groupbox to not visible
                managerMenuGbox.Visible = false;
                //Set Common Tasks groupbox to visible
                manMenuGBox.Visible = true;
                // In Edit dropdown menu
                editToolStripMenuItem.DropDownItems.RemoveByKey("gamesEditToolStripMenuItem");
                editToolStripMenuItem.DropDownItems.RemoveByKey("staffEditToolStripMenuItem1");
                // In View dropdown menu
                viewToolStripMenuItem.DropDownItems.RemoveByKey("staffViewToolStripMenuItem2");
                // Disable Report menu
                MenuStrip.Items.RemoveByKey("reportToolStripMenuItem");
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Program.LoggedInUser = null;
            this.Close();
            // OPEN LOGIN FORM HERE
            this.Close();
            LoginForm.Show();
        }



        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.SaveDatabase();
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.LoadDatabase();
        }

        private void enquireAvailableBtn_Click(object sender, EventArgs e)
        {
        }

        private void staffEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStaff addStaffForm = new AddStaff();
            addStaffForm.Show();
        }

        private void staffViewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewStaff viewStaff = new ViewStaff();
            viewStaff.Show();
        }

        private void accountTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionsReportForm transactReportForm = new TransactionsReportForm();
            transactReportForm.Show();
        }

        private void gamesViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditGamesForm viewEditGames = new ViewEditGamesForm();
            viewEditGames.Show();
        }

        private void gamesEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditGamesForm editGamesForm = new EditGamesForm();
            editGamesForm.Show();
        }

        private void processReturnedBtn_Click(object sender, EventArgs e)
        {
            ProcessReturnedForm processReturnsForm = new ProcessReturnedForm();
            processReturnsForm.Show();
        }

        private void transacrReportBtn_Click(object sender, EventArgs e)
        {
            accountTransactionsToolStripMenuItem_Click(sender, e);
        }
    }
}
