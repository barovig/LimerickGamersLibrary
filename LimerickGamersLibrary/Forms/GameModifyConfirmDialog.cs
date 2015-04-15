using System;
using System.Drawing;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class GameModifyConfirmDialog : Form
    {
        public GameModifyConfirmDialog()
        {
            InitializeComponent();
        }

        public GameModifyConfirmDialog(Game game, string action)
        {
            // Initialize components first
            InitializeComponent();
            // Set window texts
            this.Text = "Confirm " + action;
            confMsg.Text = action + " -  Game ID: " + game.GameId;
            confMsg.Location = new Point(this.Width / 2 - confMsg.Width / 2, confMsg.Location.Y);

            okBtn.Text = action;
            // Set textboxes to game info
            gameTbox.Text = game.GameName;
            platformTbox.Text = game.Platform;
            devTbox.Text = game.Developer;
            genreTBox.Text = game.Genre;
            pubTbox.Text = game.Publisher;
            yearTbox.Text = game.Year;
            ratingTbox.Text = Enum.GetName(typeof(EsrbRating), game.Rating);
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Delete Item?", "Confirm Delete", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                this.DialogResult = dialogResult;
            }
        }

    }
}
