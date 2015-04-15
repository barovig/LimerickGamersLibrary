namespace LimerickGamersLibrary.Forms
{
    partial class ViewEditStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEditStock));
            this.viewStockMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.viewStockToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.gamesListView = new System.Windows.Forms.ListView();
            this.gameIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.platformCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.devCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisherCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ratingCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockItemsListView = new System.Windows.Forms.ListView();
            this.itemIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemGameId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.onRentCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gamesLibraryLbl = new System.Windows.Forms.Label();
            this.stockLbl = new System.Windows.Forms.Label();
            this.addStockItemBtn = new System.Windows.Forms.Button();
            this.deleteStockItemBtn = new System.Windows.Forms.Button();
            this.toggleRentBtn = new System.Windows.Forms.Button();
            this.viewStockMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewStockMenuStrip
            // 
            this.viewStockMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.viewStockMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editGameToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.viewStockMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.viewStockMenuStrip.Name = "viewStockMenuStrip";
            this.viewStockMenuStrip.Size = new System.Drawing.Size(842, 24);
            this.viewStockMenuStrip.TabIndex = 3;
            this.viewStockMenuStrip.Text = "View Efit Stock";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDatabaseToolStripMenuItem,
            this.saveDatabaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDatabaseToolStripMenuItem
            // 
            this.loadDatabaseToolStripMenuItem.Name = "loadDatabaseToolStripMenuItem";
            this.loadDatabaseToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.loadDatabaseToolStripMenuItem.Text = "Load Database";
            this.loadDatabaseToolStripMenuItem.Click += new System.EventHandler(this.loadDatabaseToolStripMenuItem_Click);
            // 
            // saveDatabaseToolStripMenuItem
            // 
            this.saveDatabaseToolStripMenuItem.Name = "saveDatabaseToolStripMenuItem";
            this.saveDatabaseToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveDatabaseToolStripMenuItem.Text = "Save Database";
            this.saveDatabaseToolStripMenuItem.Click += new System.EventHandler(this.saveDatabaseToolStripMenuItem_Click);
            // 
            // editGameToolStripMenuItem
            // 
            this.editGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamesLibraryToolStripMenuItem,
            this.stockItemsToolStripMenuItem});
            this.editGameToolStripMenuItem.Name = "editGameToolStripMenuItem";
            this.editGameToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editGameToolStripMenuItem.Text = "Edit";
            // 
            // gamesLibraryToolStripMenuItem
            // 
            this.gamesLibraryToolStripMenuItem.Name = "gamesLibraryToolStripMenuItem";
            this.gamesLibraryToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.gamesLibraryToolStripMenuItem.Text = "Games Library";
            this.gamesLibraryToolStripMenuItem.Click += new System.EventHandler(this.gamesLibraryToolStripMenuItem_Click);
            // 
            // stockItemsToolStripMenuItem
            // 
            this.stockItemsToolStripMenuItem.Name = "stockItemsToolStripMenuItem";
            this.stockItemsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.stockItemsToolStripMenuItem.Text = "Stock Items";
            this.stockItemsToolStripMenuItem.Click += new System.EventHandler(this.stockItemsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStockToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // viewStockToolStrip
            // 
            this.viewStockToolStrip.Name = "viewStockToolStrip";
            this.viewStockToolStrip.Size = new System.Drawing.Size(149, 17);
            this.viewStockToolStrip.Text = "Select game to view its stock.";
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
            this.ratingCol});
            this.gamesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamesListView.FullRowSelect = true;
            this.gamesListView.GridLines = true;
            this.gamesListView.HideSelection = false;
            this.gamesListView.Location = new System.Drawing.Point(28, 79);
            this.gamesListView.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gamesListView.MultiSelect = false;
            this.gamesListView.Name = "gamesListView";
            this.gamesListView.Size = new System.Drawing.Size(442, 343);
            this.gamesListView.TabIndex = 5;
            this.gamesListView.UseCompatibleStateImageBehavior = false;
            this.gamesListView.View = System.Windows.Forms.View.Details;
            this.gamesListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
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
            this.yearCol.Width = 34;
            // 
            // ratingCol
            // 
            this.ratingCol.Text = "ESRB Rating";
            this.ratingCol.Width = 82;
            // 
            // stockItemsListView
            // 
            this.stockItemsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemIdCol,
            this.itemGameId,
            this.onRentCol});
            this.stockItemsListView.FullRowSelect = true;
            this.stockItemsListView.GridLines = true;
            this.stockItemsListView.HideSelection = false;
            this.stockItemsListView.Location = new System.Drawing.Point(521, 79);
            this.stockItemsListView.MultiSelect = false;
            this.stockItemsListView.Name = "stockItemsListView";
            this.stockItemsListView.Size = new System.Drawing.Size(190, 343);
            this.stockItemsListView.TabIndex = 6;
            this.stockItemsListView.UseCompatibleStateImageBehavior = false;
            this.stockItemsListView.View = System.Windows.Forms.View.Details;
            this.stockItemsListView.SelectedIndexChanged += new System.EventHandler(this.stockItemsListView_SelectedIndexChanged);
            this.stockItemsListView.MouseEnter += new System.EventHandler(this.stockItemsListView_MouseEnter);
            this.stockItemsListView.MouseLeave += new System.EventHandler(this.stockItemsListView_MouseLeave);
            // 
            // itemIdCol
            // 
            this.itemIdCol.Text = "Item ID";
            // 
            // itemGameId
            // 
            this.itemGameId.Text = "Game ID";
            // 
            // onRentCol
            // 
            this.onRentCol.Text = "On Rent";
            this.onRentCol.Width = 66;
            // 
            // gamesLibraryLbl
            // 
            this.gamesLibraryLbl.AutoSize = true;
            this.gamesLibraryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesLibraryLbl.Location = new System.Drawing.Point(24, 45);
            this.gamesLibraryLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gamesLibraryLbl.Name = "gamesLibraryLbl";
            this.gamesLibraryLbl.Size = new System.Drawing.Size(61, 20);
            this.gamesLibraryLbl.TabIndex = 7;
            this.gamesLibraryLbl.Text = "Games";
            // 
            // stockLbl
            // 
            this.stockLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stockLbl.AutoSize = true;
            this.stockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLbl.Location = new System.Drawing.Point(517, 45);
            this.stockLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(50, 20);
            this.stockLbl.TabIndex = 8;
            this.stockLbl.Text = "Stock";
            // 
            // addStockItemBtn
            // 
            this.addStockItemBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addStockItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.addStockItemBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.addStockItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.addStockItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStockItemBtn.Location = new System.Drawing.Point(742, 213);
            this.addStockItemBtn.Name = "addStockItemBtn";
            this.addStockItemBtn.Size = new System.Drawing.Size(75, 50);
            this.addStockItemBtn.TabIndex = 9;
            this.addStockItemBtn.Text = "Add Item";
            this.addStockItemBtn.UseVisualStyleBackColor = true;
            this.addStockItemBtn.Click += new System.EventHandler(this.addStockItemBtn_Click);
            this.addStockItemBtn.MouseLeave += new System.EventHandler(this.addStockItemBtn_MouseLeave);
            this.addStockItemBtn.MouseHover += new System.EventHandler(this.addStockItemBtn_MouseHover);
            // 
            // deleteStockItemBtn
            // 
            this.deleteStockItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteStockItemBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.deleteStockItemBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.deleteStockItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.deleteStockItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStockItemBtn.Location = new System.Drawing.Point(742, 307);
            this.deleteStockItemBtn.Name = "deleteStockItemBtn";
            this.deleteStockItemBtn.Size = new System.Drawing.Size(75, 50);
            this.deleteStockItemBtn.TabIndex = 10;
            this.deleteStockItemBtn.Text = "Delete Item";
            this.deleteStockItemBtn.UseVisualStyleBackColor = true;
            this.deleteStockItemBtn.Click += new System.EventHandler(this.deleteStockItemBtn_Click);
            this.deleteStockItemBtn.MouseLeave += new System.EventHandler(this.deleteStockItemBtn_MouseLeave);
            this.deleteStockItemBtn.MouseHover += new System.EventHandler(this.deleteStockItemBtn_MouseHover);
            // 
            // toggleRentBtn
            // 
            this.toggleRentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleRentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.toggleRentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.toggleRentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.toggleRentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleRentBtn.Location = new System.Drawing.Point(742, 119);
            this.toggleRentBtn.Name = "toggleRentBtn";
            this.toggleRentBtn.Size = new System.Drawing.Size(75, 50);
            this.toggleRentBtn.TabIndex = 11;
            this.toggleRentBtn.Text = "Toggle On Rent";
            this.toggleRentBtn.UseVisualStyleBackColor = true;
            this.toggleRentBtn.Click += new System.EventHandler(this.toggleRentBtn_Click);
            this.toggleRentBtn.MouseLeave += new System.EventHandler(this.toggleRentBtn_MouseLeave);
            this.toggleRentBtn.MouseHover += new System.EventHandler(this.toggleRentBtn_MouseHover);
            // 
            // ViewEditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(842, 473);
            this.Controls.Add(this.toggleRentBtn);
            this.Controls.Add(this.deleteStockItemBtn);
            this.Controls.Add(this.addStockItemBtn);
            this.Controls.Add(this.stockLbl);
            this.Controls.Add(this.gamesLibraryLbl);
            this.Controls.Add(this.stockItemsListView);
            this.Controls.Add(this.gamesListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.viewStockMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "ViewEditStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Review";
            this.viewStockMenuStrip.ResumeLayout(false);
            this.viewStockMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip viewStockMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView gamesListView;
        private System.Windows.Forms.ColumnHeader gameIdCol;
        private System.Windows.Forms.ColumnHeader gameNameCol;
        private System.Windows.Forms.ColumnHeader genreCol;
        private System.Windows.Forms.ColumnHeader platformCol;
        private System.Windows.Forms.ColumnHeader devCol;
        private System.Windows.Forms.ColumnHeader publisherCol;
        private System.Windows.Forms.ColumnHeader yearCol;
        private System.Windows.Forms.ColumnHeader ratingCol;
        private System.Windows.Forms.ListView stockItemsListView;
        private System.Windows.Forms.ColumnHeader itemIdCol;
        private System.Windows.Forms.ColumnHeader itemGameId;
        private System.Windows.Forms.ColumnHeader onRentCol;
        private System.Windows.Forms.ToolStripStatusLabel viewStockToolStrip;
        private System.Windows.Forms.Label gamesLibraryLbl;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.Button addStockItemBtn;
        private System.Windows.Forms.Button deleteStockItemBtn;
        private System.Windows.Forms.Button toggleRentBtn;
    }
}