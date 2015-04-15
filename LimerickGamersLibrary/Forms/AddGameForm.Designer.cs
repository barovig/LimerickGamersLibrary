namespace LimerickGamersLibrary.Forms
{
    partial class AddGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ratingCBox = new System.Windows.Forms.ComboBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.yearTbox = new System.Windows.Forms.TextBox();
            this.pubTbox = new System.Windows.Forms.TextBox();
            this.devTbox = new System.Windows.Forms.TextBox();
            this.platformTbox = new System.Windows.Forms.TextBox();
            this.gameTbox = new System.Windows.Forms.TextBox();
            this.ratingTextLbl = new System.Windows.Forms.Label();
            this.yearTextLbl = new System.Windows.Forms.Label();
            this.pubTextLbl = new System.Windows.Forms.Label();
            this.devTextLbl = new System.Windows.Forms.Label();
            this.platformTextLbl = new System.Windows.Forms.Label();
            this.gameTextLbl = new System.Windows.Forms.Label();
            this.confMsg = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.genreTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ratingCBox
            // 
            this.ratingCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingCBox.FormattingEnabled = true;
            this.ratingCBox.Location = new System.Drawing.Point(170, 238);
            this.ratingCBox.Name = "ratingCBox";
            this.ratingCBox.Size = new System.Drawing.Size(100, 21);
            this.ratingCBox.TabIndex = 7;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(190, 295);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.okBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Location = new System.Drawing.Point(68, 295);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "Add";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // yearTbox
            // 
            this.yearTbox.Location = new System.Drawing.Point(170, 210);
            this.yearTbox.Name = "yearTbox";
            this.yearTbox.Size = new System.Drawing.Size(100, 20);
            this.yearTbox.TabIndex = 6;
            // 
            // pubTbox
            // 
            this.pubTbox.Location = new System.Drawing.Point(170, 182);
            this.pubTbox.Name = "pubTbox";
            this.pubTbox.Size = new System.Drawing.Size(100, 20);
            this.pubTbox.TabIndex = 5;
            // 
            // devTbox
            // 
            this.devTbox.Location = new System.Drawing.Point(170, 154);
            this.devTbox.Name = "devTbox";
            this.devTbox.Size = new System.Drawing.Size(100, 20);
            this.devTbox.TabIndex = 4;
            // 
            // platformTbox
            // 
            this.platformTbox.Location = new System.Drawing.Point(170, 98);
            this.platformTbox.Name = "platformTbox";
            this.platformTbox.Size = new System.Drawing.Size(100, 20);
            this.platformTbox.TabIndex = 2;
            // 
            // gameTbox
            // 
            this.gameTbox.Location = new System.Drawing.Point(170, 70);
            this.gameTbox.Name = "gameTbox";
            this.gameTbox.Size = new System.Drawing.Size(100, 20);
            this.gameTbox.TabIndex = 1;
            // 
            // ratingTextLbl
            // 
            this.ratingTextLbl.AutoSize = true;
            this.ratingTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingTextLbl.Location = new System.Drawing.Point(68, 239);
            this.ratingTextLbl.Name = "ratingTextLbl";
            this.ratingTextLbl.Size = new System.Drawing.Size(94, 17);
            this.ratingTextLbl.TabIndex = 37;
            this.ratingTextLbl.Text = "ESRB Rating:";
            // 
            // yearTextLbl
            // 
            this.yearTextLbl.AutoSize = true;
            this.yearTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearTextLbl.Location = new System.Drawing.Point(120, 211);
            this.yearTextLbl.Name = "yearTextLbl";
            this.yearTextLbl.Size = new System.Drawing.Size(42, 17);
            this.yearTextLbl.TabIndex = 36;
            this.yearTextLbl.Text = "Year:";
            // 
            // pubTextLbl
            // 
            this.pubTextLbl.AutoSize = true;
            this.pubTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pubTextLbl.Location = new System.Drawing.Point(91, 183);
            this.pubTextLbl.Name = "pubTextLbl";
            this.pubTextLbl.Size = new System.Drawing.Size(71, 17);
            this.pubTextLbl.TabIndex = 35;
            this.pubTextLbl.Text = "Publisher:";
            // 
            // devTextLbl
            // 
            this.devTextLbl.AutoSize = true;
            this.devTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devTextLbl.Location = new System.Drawing.Point(85, 155);
            this.devTextLbl.Name = "devTextLbl";
            this.devTextLbl.Size = new System.Drawing.Size(77, 17);
            this.devTextLbl.TabIndex = 34;
            this.devTextLbl.Text = "Developer:";
            // 
            // platformTextLbl
            // 
            this.platformTextLbl.AutoSize = true;
            this.platformTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.platformTextLbl.Location = new System.Drawing.Point(98, 99);
            this.platformTextLbl.Name = "platformTextLbl";
            this.platformTextLbl.Size = new System.Drawing.Size(64, 17);
            this.platformTextLbl.TabIndex = 33;
            this.platformTextLbl.Text = "Platform:";
            // 
            // gameTextLbl
            // 
            this.gameTextLbl.AutoSize = true;
            this.gameTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTextLbl.Location = new System.Drawing.Point(112, 71);
            this.gameTextLbl.Name = "gameTextLbl";
            this.gameTextLbl.Size = new System.Drawing.Size(50, 17);
            this.gameTextLbl.TabIndex = 32;
            this.gameTextLbl.Text = "Game:";
            // 
            // confMsg
            // 
            this.confMsg.AutoSize = true;
            this.confMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confMsg.Location = new System.Drawing.Point(131, 23);
            this.confMsg.Name = "confMsg";
            this.confMsg.Size = new System.Drawing.Size(78, 18);
            this.confMsg.TabIndex = 30;
            this.confMsg.Text = "Add Game";
            this.confMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreLbl.Location = new System.Drawing.Point(110, 127);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(52, 17);
            this.genreLbl.TabIndex = 45;
            this.genreLbl.Text = "Genre:";
            // 
            // genreTBox
            // 
            this.genreTBox.Location = new System.Drawing.Point(170, 126);
            this.genreTBox.Name = "genreTBox";
            this.genreTBox.Size = new System.Drawing.Size(100, 20);
            this.genreTBox.TabIndex = 3;
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(340, 349);
            this.ControlBox = false;
            this.Controls.Add(this.genreTBox);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.ratingCBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.yearTbox);
            this.Controls.Add(this.pubTbox);
            this.Controls.Add(this.devTbox);
            this.Controls.Add(this.platformTbox);
            this.Controls.Add(this.gameTbox);
            this.Controls.Add(this.ratingTextLbl);
            this.Controls.Add(this.yearTextLbl);
            this.Controls.Add(this.pubTextLbl);
            this.Controls.Add(this.devTextLbl);
            this.Controls.Add(this.platformTextLbl);
            this.Controls.Add(this.gameTextLbl);
            this.Controls.Add(this.confMsg);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Game To Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ratingCBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TextBox yearTbox;
        private System.Windows.Forms.TextBox pubTbox;
        private System.Windows.Forms.TextBox devTbox;
        private System.Windows.Forms.TextBox platformTbox;
        private System.Windows.Forms.TextBox gameTbox;
        private System.Windows.Forms.Label ratingTextLbl;
        private System.Windows.Forms.Label yearTextLbl;
        private System.Windows.Forms.Label pubTextLbl;
        private System.Windows.Forms.Label devTextLbl;
        private System.Windows.Forms.Label platformTextLbl;
        private System.Windows.Forms.Label gameTextLbl;
        private System.Windows.Forms.Label confMsg;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.TextBox genreTBox;
    }
}