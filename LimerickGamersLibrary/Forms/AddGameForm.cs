using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class AddGameForm : Form
    {
        public AddGameForm()
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

            // Set label location
            confMsg.Location = new Point(this.Width / 2 - confMsg.Width / 2, confMsg.Location.Y);


        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Add Game?", "Confirm Add", MessageBoxButtons.OKCancel);
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
                    Game newGame = new Game(gameTbox.Text, devTbox.Text, pubTbox.Text, genreTBox.Text, platformTbox.Text, yearTbox.Text,
                        (EsrbRating)Enum.Parse(typeof(EsrbRating), ratingCBox.Text));
                    // Modify this game
                    Model.gameList.Add(newGame);
                    this.DialogResult = DialogResult.OK;                 
                }

            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
