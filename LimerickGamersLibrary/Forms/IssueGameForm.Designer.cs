namespace LimerickGamersLibrary.Forms
{
    partial class IssueGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueGameForm));
            this.customerDetailsList = new System.Windows.Forms.ListView();
            this.customerIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SurnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GameDetailsLis = new System.Windows.Forms.ListView();
            this.GameIDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlatformCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IssueGameButton = new System.Windows.Forms.Button();
            this.issueReservedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerDetailsList
            // 
            this.customerDetailsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDetailsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerIDCol,
            this.FirstNameCol,
            this.SurnameCol});
            this.customerDetailsList.FullRowSelect = true;
            this.customerDetailsList.GridLines = true;
            this.customerDetailsList.HideSelection = false;
            this.customerDetailsList.Location = new System.Drawing.Point(13, 42);
            this.customerDetailsList.MultiSelect = false;
            this.customerDetailsList.Name = "customerDetailsList";
            this.customerDetailsList.Size = new System.Drawing.Size(325, 400);
            this.customerDetailsList.TabIndex = 0;
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
            this.FirstNameCol.Width = 127;
            // 
            // SurnameCol
            // 
            this.SurnameCol.Text = "Surname";
            this.SurnameCol.Width = 133;
            // 
            // GameDetailsLis
            // 
            this.GameDetailsLis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameDetailsLis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GameIDCol,
            this.gameNameCol,
            this.PlatformCol});
            this.GameDetailsLis.FullRowSelect = true;
            this.GameDetailsLis.GridLines = true;
            this.GameDetailsLis.HideSelection = false;
            this.GameDetailsLis.Location = new System.Drawing.Point(359, 42);
            this.GameDetailsLis.MultiSelect = false;
            this.GameDetailsLis.Name = "GameDetailsLis";
            this.GameDetailsLis.Size = new System.Drawing.Size(310, 400);
            this.GameDetailsLis.TabIndex = 1;
            this.GameDetailsLis.UseCompatibleStateImageBehavior = false;
            this.GameDetailsLis.View = System.Windows.Forms.View.Details;
            // 
            // GameIDCol
            // 
            this.GameIDCol.Text = "Game ID";
            this.GameIDCol.Width = 56;
            // 
            // gameNameCol
            // 
            this.gameNameCol.Text = "Game Name";
            this.gameNameCol.Width = 190;
            // 
            // PlatformCol
            // 
            this.PlatformCol.Text = "Platform";
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
            this.IssueGameButton.Location = new System.Drawing.Point(722, 153);
            this.IssueGameButton.Name = "IssueGameButton";
            this.IssueGameButton.Size = new System.Drawing.Size(75, 50);
            this.IssueGameButton.TabIndex = 2;
            this.IssueGameButton.Text = "Issue";
            this.IssueGameButton.UseVisualStyleBackColor = true;
            this.IssueGameButton.Click += new System.EventHandler(this.IssueGameButton_Click);
            // 
            // issueReservedBtn
            // 
            this.issueReservedBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.issueReservedBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.issueReservedBtn.FlatAppearance.BorderSize = 3;
            this.issueReservedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.issueReservedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.issueReservedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueReservedBtn.Location = new System.Drawing.Point(722, 246);
            this.issueReservedBtn.Name = "issueReservedBtn";
            this.issueReservedBtn.Size = new System.Drawing.Size(75, 50);
            this.issueReservedBtn.TabIndex = 3;
            this.issueReservedBtn.Text = "Issue Reserved";
            this.issueReservedBtn.UseVisualStyleBackColor = true;
            this.issueReservedBtn.Click += new System.EventHandler(this.issueReservedBtn_Click);
            // 
            // IssueGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(842, 473);
            this.Controls.Add(this.issueReservedBtn);
            this.Controls.Add(this.IssueGameButton);
            this.Controls.Add(this.GameDetailsLis);
            this.Controls.Add(this.customerDetailsList);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "IssueGameForm";
            this.Text = "Issue Game Form";
            this.Load += new System.EventHandler(this.IssueGameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView customerDetailsList;
        private System.Windows.Forms.ColumnHeader customerIDCol;
        private System.Windows.Forms.ColumnHeader FirstNameCol;
        private System.Windows.Forms.ColumnHeader SurnameCol;
        private System.Windows.Forms.ListView GameDetailsLis;
        private System.Windows.Forms.ColumnHeader GameIDCol;
        private System.Windows.Forms.ColumnHeader gameNameCol;
        private System.Windows.Forms.ColumnHeader PlatformCol;
        private System.Windows.Forms.Button IssueGameButton;
        private System.Windows.Forms.Button issueReservedBtn;
    }
}