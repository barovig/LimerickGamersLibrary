using System;
using System.Drawing;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class ConfirmIssueGame : Form
    {

        public ConfirmIssueGame()
        {
            InitializeComponent();
        }

        public ConfirmIssueGame(Customer customer, Game game)
        {
            InitializeComponent();
            // Set textboxes to game info
            custIDTb.Text = customer.CustomerId;
            custNameTb.Text = customer.Name;
            custSurnameTb.Text = customer.Surname;
            gameNameTb.Text = game.GameName;
            platformTb.Text = game.Platform;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
