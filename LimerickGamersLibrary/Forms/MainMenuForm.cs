using System;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;
using LimerickGamersLibrary;

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
            ViewAvailableGames viewAvailable = new ViewAvailableGames();
            viewAvailable.Show();
        }

        private void staffEditToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void staffViewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StaffDetails viewStaff = new StaffDetails();
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

        private void overdueReportBtn_Click(object sender, EventArgs e)
        {
            Overdue overdueForm = new Overdue();
            overdueForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStaff deleteStaff = new DeleteStaff();
            deleteStaff.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaff addStaffForm = new AddStaff();
            addStaffForm.ShowDialog();
        }

        private void membersEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCustomerForm editCustomerForm = new EditCustomerForm();
            editCustomerForm.Show();
        }

        private void customersViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCustomerForm viewEditCustomer = new ViewCustomerForm();
            viewEditCustomer.Show();
        }

        private void issueGamesBtn_Click(object sender, EventArgs e)
        {
            IssueGameForm issueGameForm = new IssueGameForm();
            issueGameForm.Show();
        }

        private void editStaffBtn_Click(object sender, EventArgs e)
        {
            StaffDetails viewStaff = new StaffDetails();
            viewStaff.Show();
        }

        private void catalogReportBtn_Click(object sender, EventArgs e)
        {
            GameReportForm gameReport = new GameReportForm();
            gameReport.Show();
        }

        private void overdueGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            overdueReportBtn_Click(sender, e);
        }

        private void gameCatalogueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            catalogReportBtn_Click(sender, e);
        }

        private void reserveGanesBtn_Click(object sender, EventArgs e)
        {
            ReserveID reserveGame = new ReserveID();
            reserveGame.Show();
        }
    }
}
