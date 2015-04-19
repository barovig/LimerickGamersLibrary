namespace LimerickGamersLibrary.Forms
{
    partial class ViewEditGamesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEditGamesForm));
            this.gamesListView = new System.Windows.Forms.ListView();
            this.gameIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.platformCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.devCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisherCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ratingCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copiesCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamesLibraryLbl = new System.Windows.Forms.Label();
            this.libraryMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelDoubleClick = new System.Windows.Forms.ToolStripStatusLabel();
            this.genreFiltLbl = new System.Windows.Forms.Label();
            this.filterOptionsGBox = new System.Windows.Forms.GroupBox();
            this.ratingCBox = new System.Windows.Forms.ComboBox();
            this.yearCBox = new System.Windows.Forms.ComboBox();
            this.publCBox = new System.Windows.Forms.ComboBox();
            this.devCBox = new System.Windows.Forms.ComboBox();
            this.platformCBox = new System.Windows.Forms.ComboBox();
            this.genreCBox = new System.Windows.Forms.ComboBox();
            this.ratignFilterLbl = new System.Windows.Forms.Label();
            this.availabilityGBox = new System.Windows.Forms.GroupBox();
            this.showAllRBtn = new System.Windows.Forms.RadioButton();
            this.availableStockRBtn = new System.Windows.Forms.RadioButton();
            this.yearFilterLbl = new System.Windows.Forms.Label();
            this.pubFilterLbl = new System.Windows.Forms.Label();
            this.devFilterLbl = new System.Windows.Forms.Label();
            this.platformFilterLbl = new System.Windows.Forms.Label();
            this.libraryMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.filterOptionsGBox.SuspendLayout();
            this.availabilityGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamesListView
            // 
            this.gamesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gameIdCol,
            this.gameNameCol,
            this.genreCol,
            this.platformCol,
            this.devCol,
            this.publisherCol,
            this.yearCol,
            this.ratingCol,
            this.copiesCol});
            this.gamesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesListView.FullRowSelect = true;
            this.gamesListView.GridLines = true;
            this.gamesListView.HideSelection = false;
            this.gamesListView.Location = new System.Drawing.Point(28, 79);
            this.gamesListView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gamesListView.MultiSelect = false;
            this.gamesListView.Name = "gamesListView";
            this.gamesListView.Size = new System.Drawing.Size(540, 343);
            this.gamesListView.TabIndex = 0;
            this.gamesListView.UseCompatibleStateImageBehavior = false;
            this.gamesListView.View = System.Windows.Forms.View.Details;
            this.gamesListView.DoubleClick += new System.EventHandler(this.gamesListView_DoubleClick);
            // 
            // gameIdCol
            // 
            this.gameIdCol.Text = "ID";
            this.gameIdCol.Width = 27;
            // 
            // gameNameCol
            // 
            this.gameNameCol.Text = "Game Name";
            this.gameNameCol.Width = 74;
            // 
            // genreCol
            // 
            this.genreCol.Text = "Genre";
            this.genreCol.Width = 48;
            // 
            // platformCol
            // 
            this.platformCol.Text = "Platform";
            this.platformCol.Width = 52;
            // 
            // devCol
            // 
            this.devCol.Text = "Developer";
            this.devCol.Width = 61;
            // 
            // publisherCol
            // 
            this.publisherCol.Text = "Publisher";
            // 
            // yearCol
            // 
            this.yearCol.Text = "Year";
            this.yearCol.Width = 43;
            // 
            // ratingCol
            // 
            this.ratingCol.Text = "ESRB Rating";
            this.ratingCol.Width = 84;
            // 
            // copiesCol
            // 
            this.copiesCol.Text = "Available Stock";
            this.copiesCol.Width = 86;
            // 
            // gamesLibraryLbl
            // 
            this.gamesLibraryLbl.AutoSize = true;
            this.gamesLibraryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesLibraryLbl.Location = new System.Drawing.Point(337, 38);
            this.gamesLibraryLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gamesLibraryLbl.Name = "gamesLibraryLbl";
            this.gamesLibraryLbl.Size = new System.Drawing.Size(152, 25);
            this.gamesLibraryLbl.TabIndex = 1;
            this.gamesLibraryLbl.Text = "Games Library";
            // 
            // libraryMenuStrip
            // 
            this.libraryMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.libraryMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editGameToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.libraryMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.libraryMenuStrip.Name = "libraryMenuStrip";
            this.libraryMenuStrip.Size = new System.Drawing.Size(842, 24);
            this.libraryMenuStrip.TabIndex = 2;
            this.libraryMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDatabaseToolStripMenuItem,
            this.saveDatabaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadDatabaseToolStripMenuItem
            // 
            this.loadDatabaseToolStripMenuItem.Name = "loadDatabaseToolStripMenuItem";
            this.loadDatabaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadDatabaseToolStripMenuItem.Text = "&Load Database";
            this.loadDatabaseToolStripMenuItem.Click += new System.EventHandler(this.loadDatabaseToolStripMenuItem_Click);
            // 
            // saveDatabaseToolStripMenuItem
            // 
            this.saveDatabaseToolStripMenuItem.Name = "saveDatabaseToolStripMenuItem";
            this.saveDatabaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveDatabaseToolStripMenuItem.Text = "&Save Database";
            this.saveDatabaseToolStripMenuItem.Click += new System.EventHandler(this.saveDatabaseToolStripMenuItem_Click);
            // 
            // editGameToolStripMenuItem
            // 
            this.editGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesLibraryToolStripMenuItem,
            this.stockItemsToolStripMenuItem});
            this.editGameToolStripMenuItem.Name = "editGameToolStripMenuItem";
            this.editGameToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editGameToolStripMenuItem.Text = "&Edit";
            // 
            // gamesLibraryToolStripMenuItem
            // 
            this.gamesLibraryToolStripMenuItem.Name = "gamesLibraryToolStripMenuItem";
            this.gamesLibraryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gamesLibraryToolStripMenuItem.Text = "&Games Library";
            this.gamesLibraryToolStripMenuItem.Click += new System.EventHandler(this.gamesLibraryToolStripMenuItem_Click);
            // 
            // stockItemsToolStripMenuItem
            // 
            this.stockItemsToolStripMenuItem.Name = "stockItemsToolStripMenuItem";
            this.stockItemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stockItemsToolStripMenuItem.Text = "S&tock Items";
            this.stockItemsToolStripMenuItem.Click += new System.EventHandler(this.stockItemsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stockToolStripMenuItem.Text = "S&tock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelDoubleClick});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelDoubleClick
            // 
            this.statusLabelDoubleClick.Name = "statusLabelDoubleClick";
            this.statusLabelDoubleClick.Size = new System.Drawing.Size(214, 17);
            this.statusLabelDoubleClick.Text = "Double click selected game to view its stock";
            // 
            // genreFiltLbl
            // 
            this.genreFiltLbl.AutoSize = true;
            this.genreFiltLbl.Location = new System.Drawing.Point(75, 35);
            this.genreFiltLbl.Name = "genreFiltLbl";
            this.genreFiltLbl.Size = new System.Drawing.Size(39, 13);
            this.genreFiltLbl.TabIndex = 5;
            this.genreFiltLbl.Text = "Genre:";
            // 
            // filterOptionsGBox
            // 
            this.filterOptionsGBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterOptionsGBox.Controls.Add(this.ratingCBox);
            this.filterOptionsGBox.Controls.Add(this.yearCBox);
            this.filterOptionsGBox.Controls.Add(this.publCBox);
            this.filterOptionsGBox.Controls.Add(this.devCBox);
            this.filterOptionsGBox.Controls.Add(this.platformCBox);
            this.filterOptionsGBox.Controls.Add(this.genreCBox);
            this.filterOptionsGBox.Controls.Add(this.ratignFilterLbl);
            this.filterOptionsGBox.Controls.Add(this.availabilityGBox);
            this.filterOptionsGBox.Controls.Add(this.yearFilterLbl);
            this.filterOptionsGBox.Controls.Add(this.pubFilterLbl);
            this.filterOptionsGBox.Controls.Add(this.devFilterLbl);
            this.filterOptionsGBox.Controls.Add(this.platformFilterLbl);
            this.filterOptionsGBox.Controls.Add(this.genreFiltLbl);
            this.filterOptionsGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterOptionsGBox.Location = new System.Drawing.Point(593, 79);
            this.filterOptionsGBox.Name = "filterOptionsGBox";
            this.filterOptionsGBox.Size = new System.Drawing.Size(237, 343);
            this.filterOptionsGBox.TabIndex = 6;
            this.filterOptionsGBox.TabStop = false;
            this.filterOptionsGBox.Text = "Filtering Options";
            // 
            // ratingCBox
            // 
            this.ratingCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingCBox.FormattingEnabled = true;
            this.ratingCBox.Location = new System.Drawing.Point(120, 232);
            this.ratingCBox.Name = "ratingCBox";
            this.ratingCBox.Size = new System.Drawing.Size(101, 21);
            this.ratingCBox.TabIndex = 22;
            this.ratingCBox.SelectedIndexChanged += new System.EventHandler(this.ratingCBox_SelectedIndexChanged);
            // 
            // yearCBox
            // 
            this.yearCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCBox.FormattingEnabled = true;
            this.yearCBox.Location = new System.Drawing.Point(120, 192);
            this.yearCBox.Name = "yearCBox";
            this.yearCBox.Size = new System.Drawing.Size(101, 21);
            this.yearCBox.TabIndex = 21;
            this.yearCBox.SelectedIndexChanged += new System.EventHandler(this.yearCBox_SelectedIndexChanged);
            // 
            // publCBox
            // 
            this.publCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publCBox.FormattingEnabled = true;
            this.publCBox.Location = new System.Drawing.Point(120, 152);
            this.publCBox.Name = "publCBox";
            this.publCBox.Size = new System.Drawing.Size(101, 21);
            this.publCBox.TabIndex = 20;
            this.publCBox.SelectedIndexChanged += new System.EventHandler(this.publCBox_SelectedIndexChanged);
            // 
            // devCBox
            // 
            this.devCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devCBox.FormattingEnabled = true;
            this.devCBox.Location = new System.Drawing.Point(120, 112);
            this.devCBox.Name = "devCBox";
            this.devCBox.Size = new System.Drawing.Size(101, 21);
            this.devCBox.TabIndex = 19;
            this.devCBox.SelectedIndexChanged += new System.EventHandler(this.devCBox_SelectedIndexChanged);
            // 
            // platformCBox
            // 
            this.platformCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platformCBox.FormattingEnabled = true;
            this.platformCBox.Location = new System.Drawing.Point(120, 72);
            this.platformCBox.Name = "platformCBox";
            this.platformCBox.Size = new System.Drawing.Size(101, 21);
            this.platformCBox.TabIndex = 18;
            this.platformCBox.SelectedIndexChanged += new System.EventHandler(this.platformCBox_SelectedIndexChanged);
            // 
            // genreCBox
            // 
            this.genreCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCBox.FormattingEnabled = true;
            this.genreCBox.Location = new System.Drawing.Point(120, 32);
            this.genreCBox.Name = "genreCBox";
            this.genreCBox.Size = new System.Drawing.Size(101, 21);
            this.genreCBox.TabIndex = 17;
            this.genreCBox.SelectedIndexChanged += new System.EventHandler(this.genreCBox_SelectedIndexChanged);
            // 
            // ratignFilterLbl
            // 
            this.ratignFilterLbl.AutoSize = true;
            this.ratignFilterLbl.Location = new System.Drawing.Point(41, 235);
            this.ratignFilterLbl.Name = "ratignFilterLbl";
            this.ratignFilterLbl.Size = new System.Drawing.Size(73, 13);
            this.ratignFilterLbl.TabIndex = 16;
            this.ratignFilterLbl.Text = "ESRB Rating:";
            // 
            // availabilityGBox
            // 
            this.availabilityGBox.Controls.Add(this.showAllRBtn);
            this.availabilityGBox.Controls.Add(this.availableStockRBtn);
            this.availabilityGBox.Location = new System.Drawing.Point(20, 271);
            this.availabilityGBox.Name = "availabilityGBox";
            this.availabilityGBox.Size = new System.Drawing.Size(197, 49);
            this.availabilityGBox.TabIndex = 10;
            this.availabilityGBox.TabStop = false;
            this.availabilityGBox.Text = "Show";
            // 
            // showAllRBtn
            // 
            this.showAllRBtn.AutoSize = true;
            this.showAllRBtn.Checked = true;
            this.showAllRBtn.Location = new System.Drawing.Point(140, 19);
            this.showAllRBtn.Name = "showAllRBtn";
            this.showAllRBtn.Size = new System.Drawing.Size(36, 17);
            this.showAllRBtn.TabIndex = 1;
            this.showAllRBtn.TabStop = true;
            this.showAllRBtn.Text = "All";
            this.showAllRBtn.UseVisualStyleBackColor = true;
            this.showAllRBtn.CheckedChanged += new System.EventHandler(this.showAllRBtn_CheckedChanged);
            // 
            // availableStockRBtn
            // 
            this.availableStockRBtn.AutoSize = true;
            this.availableStockRBtn.Location = new System.Drawing.Point(22, 19);
            this.availableStockRBtn.Name = "availableStockRBtn";
            this.availableStockRBtn.Size = new System.Drawing.Size(92, 17);
            this.availableStockRBtn.TabIndex = 0;
            this.availableStockRBtn.Text = "Available Only";
            this.availableStockRBtn.UseVisualStyleBackColor = true;
            this.availableStockRBtn.CheckedChanged += new System.EventHandler(this.availableStockRBtn_CheckedChanged);
            // 
            // yearFilterLbl
            // 
            this.yearFilterLbl.AutoSize = true;
            this.yearFilterLbl.Location = new System.Drawing.Point(33, 195);
            this.yearFilterLbl.Name = "yearFilterLbl";
            this.yearFilterLbl.Size = new System.Drawing.Size(81, 13);
            this.yearFilterLbl.TabIndex = 9;
            this.yearFilterLbl.Text = "Year Published:";
            // 
            // pubFilterLbl
            // 
            this.pubFilterLbl.AutoSize = true;
            this.pubFilterLbl.Location = new System.Drawing.Point(61, 155);
            this.pubFilterLbl.Name = "pubFilterLbl";
            this.pubFilterLbl.Size = new System.Drawing.Size(53, 13);
            this.pubFilterLbl.TabIndex = 8;
            this.pubFilterLbl.Text = "Publisher:";
            // 
            // devFilterLbl
            // 
            this.devFilterLbl.AutoSize = true;
            this.devFilterLbl.Location = new System.Drawing.Point(55, 115);
            this.devFilterLbl.Name = "devFilterLbl";
            this.devFilterLbl.Size = new System.Drawing.Size(59, 13);
            this.devFilterLbl.TabIndex = 7;
            this.devFilterLbl.Text = "Developer:";
            // 
            // platformFilterLbl
            // 
            this.platformFilterLbl.AutoSize = true;
            this.platformFilterLbl.Location = new System.Drawing.Point(20, 75);
            this.platformFilterLbl.Name = "platformFilterLbl";
            this.platformFilterLbl.Size = new System.Drawing.Size(94, 13);
            this.platformFilterLbl.TabIndex = 6;
            this.platformFilterLbl.Text = "Platform Available:";
            // 
            // ViewEditGamesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(842, 473);
            this.Controls.Add(this.filterOptionsGBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gamesLibraryLbl);
            this.Controls.Add(this.gamesListView);
            this.Controls.Add(this.libraryMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.libraryMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "ViewEditGamesForm";
            this.Text = "Games Library And Stock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewEditGamesForm_FormClosed);
            this.libraryMenuStrip.ResumeLayout(false);
            this.libraryMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.filterOptionsGBox.ResumeLayout(false);
            this.filterOptionsGBox.PerformLayout();
            this.availabilityGBox.ResumeLayout(false);
            this.availabilityGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView gamesListView;
        private System.Windows.Forms.Label gamesLibraryLbl;
        private System.Windows.Forms.ColumnHeader gameIdCol;
        private System.Windows.Forms.ColumnHeader gameNameCol;
        private System.Windows.Forms.ColumnHeader genreCol;
        private System.Windows.Forms.ColumnHeader platformCol;
        private System.Windows.Forms.ColumnHeader devCol;
        private System.Windows.Forms.ColumnHeader publisherCol;
        private System.Windows.Forms.ColumnHeader yearCol;
        private System.Windows.Forms.ColumnHeader ratingCol;
        private System.Windows.Forms.ColumnHeader copiesCol;
        private System.Windows.Forms.MenuStrip libraryMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockItemsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelDoubleClick;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.Label genreFiltLbl;
        private System.Windows.Forms.GroupBox filterOptionsGBox;
        private System.Windows.Forms.GroupBox availabilityGBox;
        private System.Windows.Forms.RadioButton availableStockRBtn;
        private System.Windows.Forms.Label yearFilterLbl;
        private System.Windows.Forms.Label pubFilterLbl;
        private System.Windows.Forms.Label devFilterLbl;
        private System.Windows.Forms.Label platformFilterLbl;
        private System.Windows.Forms.RadioButton showAllRBtn;
        private System.Windows.Forms.Label ratignFilterLbl;
        private System.Windows.Forms.ComboBox ratingCBox;
        private System.Windows.Forms.ComboBox yearCBox;
        private System.Windows.Forms.ComboBox publCBox;
        private System.Windows.Forms.ComboBox devCBox;
        private System.Windows.Forms.ComboBox platformCBox;
        private System.Windows.Forms.ComboBox genreCBox;
    }
}