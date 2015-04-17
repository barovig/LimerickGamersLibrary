namespace LimerickGamersLibrary.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffEditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.staffViewToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameCatalogueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overdueGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signedInLabel = new System.Windows.Forms.Label();
            this.greetingLbl = new System.Windows.Forms.Label();
            this.manMenuGBox = new System.Windows.Forms.GroupBox();
            this.processReturnedBtn = new System.Windows.Forms.Button();
            this.reserveGanesBtn = new System.Windows.Forms.Button();
            this.issueGamesBtn = new System.Windows.Forms.Button();
            this.enquireAvailableBtn = new System.Windows.Forms.Button();
            this.managerMenuGbox = new System.Windows.Forms.GroupBox();
            this.transacrReportBtn = new System.Windows.Forms.Button();
            this.overdueReportBtn = new System.Windows.Forms.Button();
            this.catalogReportBtn = new System.Windows.Forms.Button();
            this.editStaffBtn = new System.Windows.Forms.Button();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            this.manMenuGBox.SuspendLayout();
            this.managerMenuGbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(692, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "MainMenu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDatabaseToolStripMenuItem,
            this.loadDatabaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveDatabaseToolStripMenuItem
            // 
            this.saveDatabaseToolStripMenuItem.Name = "saveDatabaseToolStripMenuItem";
            this.saveDatabaseToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveDatabaseToolStripMenuItem.Text = "&Save Database";
            this.saveDatabaseToolStripMenuItem.Click += new System.EventHandler(this.saveDatabaseToolStripMenuItem_Click);
            // 
            // loadDatabaseToolStripMenuItem
            // 
            this.loadDatabaseToolStripMenuItem.Name = "loadDatabaseToolStripMenuItem";
            this.loadDatabaseToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadDatabaseToolStripMenuItem.Text = "&Load Database";
            this.loadDatabaseToolStripMenuItem.Click += new System.EventHandler(this.loadDatabaseToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesEditToolStripMenuItem,
            this.membersEditToolStripMenuItem,
            this.staffEditToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // gamesEditToolStripMenuItem
            // 
            this.gamesEditToolStripMenuItem.Name = "gamesEditToolStripMenuItem";
            this.gamesEditToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gamesEditToolStripMenuItem.Text = "&Games";
            this.gamesEditToolStripMenuItem.Click += new System.EventHandler(this.gamesEditToolStripMenuItem_Click);
            // 
            // membersEditToolStripMenuItem
            // 
            this.membersEditToolStripMenuItem.Name = "membersEditToolStripMenuItem";
            this.membersEditToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.membersEditToolStripMenuItem.Text = "&Members";
            this.membersEditToolStripMenuItem.Click += new System.EventHandler(this.membersEditToolStripMenuItem_Click);
            // 
            // staffEditToolStripMenuItem1
            // 
            this.staffEditToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.staffEditToolStripMenuItem1.Name = "staffEditToolStripMenuItem1";
            this.staffEditToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.staffEditToolStripMenuItem1.Text = "&Staff";
            this.staffEditToolStripMenuItem1.Click += new System.EventHandler(this.staffEditToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesViewToolStripMenuItem,
            this.customersViewToolStripMenuItem1,
            this.staffViewToolStripMenuItem2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // gamesViewToolStripMenuItem
            // 
            this.gamesViewToolStripMenuItem.Name = "gamesViewToolStripMenuItem";
            this.gamesViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gamesViewToolStripMenuItem.Text = "&Games";
            this.gamesViewToolStripMenuItem.Click += new System.EventHandler(this.gamesViewToolStripMenuItem_Click);
            // 
            // customersViewToolStripMenuItem1
            // 
            this.customersViewToolStripMenuItem1.Name = "customersViewToolStripMenuItem1";
            this.customersViewToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.customersViewToolStripMenuItem1.Text = "&Members";
            this.customersViewToolStripMenuItem1.Click += new System.EventHandler(this.customersViewToolStripMenuItem1_Click);
            // 
            // staffViewToolStripMenuItem2
            // 
            this.staffViewToolStripMenuItem2.Name = "staffViewToolStripMenuItem2";
            this.staffViewToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.staffViewToolStripMenuItem2.Text = "&Staff";
            this.staffViewToolStripMenuItem2.Click += new System.EventHandler(this.staffViewToolStripMenuItem2_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameCatalogueToolStripMenuItem,
            this.overdueGamesToolStripMenuItem,
            this.accountTransactionsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // gameCatalogueToolStripMenuItem
            // 
            this.gameCatalogueToolStripMenuItem.Name = "gameCatalogueToolStripMenuItem";
            this.gameCatalogueToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gameCatalogueToolStripMenuItem.Text = "&Game Catalogue";
            this.gameCatalogueToolStripMenuItem.Click += new System.EventHandler(this.gameCatalogueToolStripMenuItem_Click);
            // 
            // overdueGamesToolStripMenuItem
            // 
            this.overdueGamesToolStripMenuItem.Name = "overdueGamesToolStripMenuItem";
            this.overdueGamesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.overdueGamesToolStripMenuItem.Text = "&Overdue Games";
            this.overdueGamesToolStripMenuItem.Click += new System.EventHandler(this.overdueGamesToolStripMenuItem_Click);
            // 
            // accountTransactionsToolStripMenuItem
            // 
            this.accountTransactionsToolStripMenuItem.Name = "accountTransactionsToolStripMenuItem";
            this.accountTransactionsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.accountTransactionsToolStripMenuItem.Text = "&Account Transactions";
            this.accountTransactionsToolStripMenuItem.Click += new System.EventHandler(this.accountTransactionsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.logoutToolStripMenuItem.Text = "L&ogout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // signedInLabel
            // 
            this.signedInLabel.AutoSize = true;
            this.signedInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signedInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.signedInLabel.Location = new System.Drawing.Point(590, 41);
            this.signedInLabel.Name = "signedInLabel";
            this.signedInLabel.Size = new System.Drawing.Size(61, 13);
            this.signedInLabel.TabIndex = 2;
            this.signedInLabel.Text = "username";
            // 
            // greetingLbl
            // 
            this.greetingLbl.AutoSize = true;
            this.greetingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.greetingLbl.Location = new System.Drawing.Point(538, 41);
            this.greetingLbl.Name = "greetingLbl";
            this.greetingLbl.Size = new System.Drawing.Size(55, 13);
            this.greetingLbl.TabIndex = 3;
            this.greetingLbl.Text = "Welcome,";
            // 
            // manMenuGBox
            // 
            this.manMenuGBox.Controls.Add(this.processReturnedBtn);
            this.manMenuGBox.Controls.Add(this.reserveGanesBtn);
            this.manMenuGBox.Controls.Add(this.issueGamesBtn);
            this.manMenuGBox.Controls.Add(this.enquireAvailableBtn);
            this.manMenuGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manMenuGBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.manMenuGBox.Location = new System.Drawing.Point(86, 218);
            this.manMenuGBox.Name = "manMenuGBox";
            this.manMenuGBox.Size = new System.Drawing.Size(500, 196);
            this.manMenuGBox.TabIndex = 4;
            this.manMenuGBox.TabStop = false;
            this.manMenuGBox.Text = "Common Tasks";
            // 
            // processReturnedBtn
            // 
            this.processReturnedBtn.BackColor = System.Drawing.Color.White;
            this.processReturnedBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.processReturnedBtn.FlatAppearance.BorderSize = 4;
            this.processReturnedBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.processReturnedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.processReturnedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processReturnedBtn.Location = new System.Drawing.Point(380, 66);
            this.processReturnedBtn.Name = "processReturnedBtn";
            this.processReturnedBtn.Size = new System.Drawing.Size(100, 66);
            this.processReturnedBtn.TabIndex = 3;
            this.processReturnedBtn.Text = "Process Returned Games";
            this.processReturnedBtn.UseVisualStyleBackColor = false;
            this.processReturnedBtn.Click += new System.EventHandler(this.processReturnedBtn_Click);
            // 
            // reserveGanesBtn
            // 
            this.reserveGanesBtn.BackColor = System.Drawing.Color.White;
            this.reserveGanesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.reserveGanesBtn.FlatAppearance.BorderSize = 4;
            this.reserveGanesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.reserveGanesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.reserveGanesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveGanesBtn.Location = new System.Drawing.Point(260, 66);
            this.reserveGanesBtn.Name = "reserveGanesBtn";
            this.reserveGanesBtn.Size = new System.Drawing.Size(100, 66);
            this.reserveGanesBtn.TabIndex = 2;
            this.reserveGanesBtn.Text = "Reserve Games";
            this.reserveGanesBtn.UseVisualStyleBackColor = false;
            this.reserveGanesBtn.Click += new System.EventHandler(this.reserveGanesBtn_Click);
            // 
            // issueGamesBtn
            // 
            this.issueGamesBtn.BackColor = System.Drawing.Color.White;
            this.issueGamesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.issueGamesBtn.FlatAppearance.BorderSize = 4;
            this.issueGamesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.issueGamesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.issueGamesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueGamesBtn.Location = new System.Drawing.Point(140, 66);
            this.issueGamesBtn.Name = "issueGamesBtn";
            this.issueGamesBtn.Size = new System.Drawing.Size(100, 66);
            this.issueGamesBtn.TabIndex = 1;
            this.issueGamesBtn.Text = "Issue Games";
            this.issueGamesBtn.UseVisualStyleBackColor = false;
            this.issueGamesBtn.Click += new System.EventHandler(this.issueGamesBtn_Click);
            // 
            // enquireAvailableBtn
            // 
            this.enquireAvailableBtn.BackColor = System.Drawing.Color.White;
            this.enquireAvailableBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.enquireAvailableBtn.FlatAppearance.BorderSize = 4;
            this.enquireAvailableBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.enquireAvailableBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.enquireAvailableBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enquireAvailableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enquireAvailableBtn.Location = new System.Drawing.Point(20, 66);
            this.enquireAvailableBtn.Name = "enquireAvailableBtn";
            this.enquireAvailableBtn.Size = new System.Drawing.Size(100, 66);
            this.enquireAvailableBtn.TabIndex = 0;
            this.enquireAvailableBtn.Text = "Enquire On Game Availability";
            this.enquireAvailableBtn.UseVisualStyleBackColor = false;
            this.enquireAvailableBtn.Click += new System.EventHandler(this.enquireAvailableBtn_Click);
            // 
            // managerMenuGbox
            // 
            this.managerMenuGbox.Controls.Add(this.transacrReportBtn);
            this.managerMenuGbox.Controls.Add(this.overdueReportBtn);
            this.managerMenuGbox.Controls.Add(this.catalogReportBtn);
            this.managerMenuGbox.Controls.Add(this.editStaffBtn);
            this.managerMenuGbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.managerMenuGbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.managerMenuGbox.Location = new System.Drawing.Point(86, 218);
            this.managerMenuGbox.Name = "managerMenuGbox";
            this.managerMenuGbox.Size = new System.Drawing.Size(500, 196);
            this.managerMenuGbox.TabIndex = 5;
            this.managerMenuGbox.TabStop = false;
            this.managerMenuGbox.Text = "Management Tasks";
            // 
            // transacrReportBtn
            // 
            this.transacrReportBtn.BackColor = System.Drawing.Color.White;
            this.transacrReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.transacrReportBtn.FlatAppearance.BorderSize = 4;
            this.transacrReportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.transacrReportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.transacrReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transacrReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transacrReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.transacrReportBtn.Location = new System.Drawing.Point(380, 66);
            this.transacrReportBtn.Name = "transacrReportBtn";
            this.transacrReportBtn.Size = new System.Drawing.Size(100, 66);
            this.transacrReportBtn.TabIndex = 3;
            this.transacrReportBtn.Text = "Transactions Report";
            this.transacrReportBtn.UseVisualStyleBackColor = false;
            this.transacrReportBtn.Click += new System.EventHandler(this.transacrReportBtn_Click);
            // 
            // overdueReportBtn
            // 
            this.overdueReportBtn.BackColor = System.Drawing.Color.White;
            this.overdueReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.overdueReportBtn.FlatAppearance.BorderSize = 4;
            this.overdueReportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.overdueReportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.overdueReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overdueReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overdueReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.overdueReportBtn.Location = new System.Drawing.Point(260, 66);
            this.overdueReportBtn.Name = "overdueReportBtn";
            this.overdueReportBtn.Size = new System.Drawing.Size(100, 66);
            this.overdueReportBtn.TabIndex = 2;
            this.overdueReportBtn.Text = "Overdue Games Report";
            this.overdueReportBtn.UseVisualStyleBackColor = false;
            this.overdueReportBtn.Click += new System.EventHandler(this.overdueReportBtn_Click);
            // 
            // catalogReportBtn
            // 
            this.catalogReportBtn.BackColor = System.Drawing.Color.White;
            this.catalogReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.catalogReportBtn.FlatAppearance.BorderSize = 4;
            this.catalogReportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.catalogReportBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.catalogReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catalogReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catalogReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.catalogReportBtn.Location = new System.Drawing.Point(140, 66);
            this.catalogReportBtn.Name = "catalogReportBtn";
            this.catalogReportBtn.Size = new System.Drawing.Size(100, 66);
            this.catalogReportBtn.TabIndex = 1;
            this.catalogReportBtn.Text = "Game Catalogue Report";
            this.catalogReportBtn.UseVisualStyleBackColor = false;
            this.catalogReportBtn.Click += new System.EventHandler(this.catalogReportBtn_Click);
            // 
            // editStaffBtn
            // 
            this.editStaffBtn.BackColor = System.Drawing.Color.White;
            this.editStaffBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.editStaffBtn.FlatAppearance.BorderSize = 4;
            this.editStaffBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.editStaffBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.editStaffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStaffBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editStaffBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.editStaffBtn.Location = new System.Drawing.Point(20, 66);
            this.editStaffBtn.Name = "editStaffBtn";
            this.editStaffBtn.Size = new System.Drawing.Size(100, 66);
            this.editStaffBtn.TabIndex = 0;
            this.editStaffBtn.Text = "Edit Staff Accounts";
            this.editStaffBtn.UseVisualStyleBackColor = false;
            this.editStaffBtn.Click += new System.EventHandler(this.editStaffBtn_Click);
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.Location = new System.Drawing.Point(136, 91);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(430, 41);
            this.logoPicBox.TabIndex = 6;
            this.logoPicBox.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.Controls.Add(this.logoPicBox);
            this.Controls.Add(this.managerMenuGbox);
            this.Controls.Add(this.manMenuGBox);
            this.Controls.Add(this.greetingLbl);
            this.Controls.Add(this.signedInLabel);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainMenuForm";
            this.Text = "Limerick Gamers Game Library";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.manMenuGBox.ResumeLayout(false);
            this.managerMenuGbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membersEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffEditToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem staffViewToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameCatalogueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overdueGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label signedInLabel;
        private System.Windows.Forms.Label greetingLbl;
        private System.Windows.Forms.GroupBox manMenuGBox;
        private System.Windows.Forms.Button processReturnedBtn;
        private System.Windows.Forms.Button reserveGanesBtn;
        private System.Windows.Forms.Button issueGamesBtn;
        private System.Windows.Forms.Button enquireAvailableBtn;
        private System.Windows.Forms.GroupBox managerMenuGbox;
        private System.Windows.Forms.Button transacrReportBtn;
        private System.Windows.Forms.Button overdueReportBtn;
        private System.Windows.Forms.Button catalogReportBtn;
        private System.Windows.Forms.Button editStaffBtn;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}