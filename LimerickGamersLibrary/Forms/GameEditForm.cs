using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class GameEditForm : Form
    {
        public GameEditForm(ref Game game)
        {
            InitializeComponent();

            // Populate Rating CBox
            // Ratings are inside enumeration
            // Enum.GetNames returns string array of all enumeration names
            string[] ratingsArray = Enum.GetNames(typeof(EsrbRating));
            // Declare a List<string> 
            List<string> ratings = new List<string>();
            // and assign ratingsArray to it
            ratings.AddRange(ratingsArray);
            ratingCBox.DataSource = ratings;

            // Set label
            confMsg.Text = "Edit Game -  Game ID: " + game.GameId;
            // Set label location
            confMsg.Location = new Point(this.Width / 2 - confMsg.Width / 2, confMsg.Location.Y);

            // Set textboxes to game info
            gameTbox.Text = game.GameName;
            platformTbox.Text = game.Platform;
            devTbox.Text = game.Developer;
            pubTbox.Text = game.Publisher;
            yearTbox.Text = game.Year;
            genreTBox.Text = game.Genre;
            ratingCBox.Text = Enum.GetName(typeof(EsrbRating), game.Rating);
            // assign passedGame
            passedGame = game;
        }

        private Game passedGame;

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apply Changes Made?", "Confirm Edit", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {   
                // Check for empty inputs
                if (
                    gameTbox.Text == "" ||
                    devTbox.Text == "" ||
                    pubTbox.Text == "" ||
                    genreTBox.Text == "" ||
                    platformTbox.Text == "" ||
                    yearTbox.Text == "" ||
                    ratingCBox.Text == ""
                    )
                {
                    MessageBox.Show("Please fill all fields.");
                }
                else
                {
                    // Modify this game
                    passedGame.GameName = gameTbox.Text;
                    passedGame.Platform = platformTbox.Text;
                    passedGame.Developer = devTbox.Text;
                    passedGame.Publisher = pubTbox.Text;
                    passedGame.Genre = genreTBox.Text;
                    passedGame.Year = yearTbox.Text;
                    passedGame.Rating = (EsrbRating)Enum.Parse(typeof(EsrbRating), ratingCBox.Text);
                    this.DialogResult = DialogResult.OK;
                }

            }
        }
    }
}
