namespace LimerickGamersLibrary.Forms
{
    partial class IssueReservedGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueReservedGameForm));
            this.IssueGameButton = new System.Windows.Forms.Button();
            this.customerDetailsList = new System.Windows.Forms.ListView();
            this.customerIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SurnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlatformCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // IssueGameButton
            // 
            this.IssueGameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssueGameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.IssueGameButton.FlatAppearance.BorderSize = 3;
            this.IssueGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.IssueGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.IssueGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IssueGameButton.Location = new System.Drawing.Point(737, 202);
            this.IssueGameButton.Name = "IssueGameButton";
            this.IssueGameButton.Size = new System.Drawing.Size(75, 50);
            this.IssueGameButton.TabIndex = 5;
            this.IssueGameButton.Text = "Issue Reserved";
            this.IssueGameButton.UseVisualStyleBackColor = true;
            this.IssueGameButton.Click += new System.EventHandler(this.IssueGameButton_Click);
            // 
            // customerDetailsList
            // 
            this.customerDetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDetailsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerIDCol,
            this.FirstNameCol,
            this.SurnameCol,
            this.GameNameCol,
            this.PlatformCol});
            this.customerDetailsList.FullRowSelect = true;
            this.customerDetailsList.GridLines = true;
            this.customerDetailsList.HideSelection = false;
            this.customerDetailsList.Location = new System.Drawing.Point(31, 36);
            this.customerDetailsList.MultiSelect = false;
            this.customerDetailsList.Name = "customerDetailsList";
            this.customerDetailsList.Size = new System.Drawing.Size(680, 400);
            this.customerDetailsList.TabIndex = 3;
            this.customerDetailsList.UseCompatibleStateImageBehavior = false;
            this.customerDetailsList.View = System.Windows.Forms.View.Details;
            // 
            // customerIDCol
            // 
            this.customerIDCol.Text = "ID";
            // 
            // FirstNameCol
            // 
            this.FirstNameCol.Text = "First Name";
            this.FirstNameCol.Width = 187;
            // 
            // SurnameCol
            // 
            this.SurnameCol.Text = "Surname";
            this.SurnameCol.Width = 133;
            // 
            // GameNameCol
            // 
            this.GameNameCol.Text = "Game Name";
            this.GameNameCol.Width = 208;
            // 
            // PlatformCol
            // 
            this.PlatformCol.Text = "Platform";
            this.PlatformCol.Width = 86;
            // 
            // IssueReservedGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(842, 473);
            this.Controls.Add(this.IssueGameButton);
            this.Controls.Add(this.customerDetailsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IssueReservedGameForm";
            this.Text = "IssueReservedGameForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IssueGameButton;
        private System.Windows.Forms.ListView customerDetailsList;
        private System.Windows.Forms.ColumnHeader customerIDCol;
        private System.Windows.Forms.ColumnHeader FirstNameCol;
        private System.Windows.Forms.ColumnHeader SurnameCol;
        private System.Windows.Forms.ColumnHeader GameNameCol;
        private System.Windows.Forms.ColumnHeader PlatformCol;

    }
}