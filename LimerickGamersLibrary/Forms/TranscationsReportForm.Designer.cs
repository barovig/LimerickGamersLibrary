namespace LimerickGamersLibrary.Forms
{
    partial class TransactionsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsReportForm));
            this.transactReportMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTotalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.transactReportLbl = new System.Windows.Forms.Label();
            this.transactListView = new System.Windows.Forms.ListView();
            this.custIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amtCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterOptionsGBox = new System.Windows.Forms.GroupBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.datesGBox = new System.Windows.Forms.GroupBox();
            this.andLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.typeCBox = new System.Windows.Forms.ComboBox();
            this.surnameCBox = new System.Windows.Forms.ComboBox();
            this.nameCBox = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.custSurnameLbl = new System.Windows.Forms.Label();
            this.custNameLbl = new System.Windows.Forms.Label();
            this.transactReportMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.filterOptionsGBox.SuspendLayout();
            this.datesGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactReportMenuStrip
            // 
            this.transactReportMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.transactReportMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewTotalsToolStripMenuItem});
            this.transactReportMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.transactReportMenuStrip.Name = "transactReportMenuStrip";
            this.transactReportMenuStrip.Size = new System.Drawing.Size(842, 24);
            this.transactReportMenuStrip.TabIndex = 4;
            this.transactReportMenuStrip.Text = "EditGamesMenuStrip";
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
            // viewTotalsToolStripMenuItem
            // 
            this.viewTotalsToolStripMenuItem.Name = "viewTotalsToolStripMenuItem";
            this.viewTotalsToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.viewTotalsToolStripMenuItem.Text = "View Totals";
            this.viewTotalsToolStripMenuItem.Click += new System.EventHandler(this.viewTotalsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 451);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(842, 22);
            this.statusStrip.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // transactReportLbl
            // 
            this.transactReportLbl.AutoSize = true;
            this.transactReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactReportLbl.Location = new System.Drawing.Point(326, 39);
            this.transactReportLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.transactReportLbl.Name = "transactReportLbl";
            this.transactReportLbl.Size = new System.Drawing.Size(206, 25);
            this.transactReportLbl.TabIndex = 7;
            this.transactReportLbl.Text = "Transactions Report";
            // 
            // transactListView
            // 
            this.transactListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.transactListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.custIdCol,
            this.nameCol,
            this.surnameCol,
            this.amtCol,
            this.dateCol,
            this.typeCol});
            this.transactListView.FullRowSelect = true;
            this.transactListView.GridLines = true;
            this.transactListView.HideSelection = false;
            this.transactListView.Location = new System.Drawing.Point(28, 79);
            this.transactListView.MultiSelect = false;
            this.transactListView.Name = "transactListView";
            this.transactListView.Size = new System.Drawing.Size(528, 343);
            this.transactListView.TabIndex = 8;
            this.transactListView.UseCompatibleStateImageBehavior = false;
            this.transactListView.View = System.Windows.Forms.View.Details;
            // 
            // custIdCol
            // 
            this.custIdCol.Text = "Customer ID";
            this.custIdCol.Width = 71;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Customer Name";
            this.nameCol.Width = 87;
            // 
            // surnameCol
            // 
            this.surnameCol.Text = "Customer Surname";
            this.surnameCol.Width = 104;
            // 
            // amtCol
            // 
            this.amtCol.Text = "Amount";
            this.amtCol.Width = 62;
            // 
            // dateCol
            // 
            this.dateCol.Text = "Transaction Date";
            this.dateCol.Width = 102;
            // 
            // typeCol
            // 
            this.typeCol.Text = "Type";
            this.typeCol.Width = 98;
            // 
            // filterOptionsGBox
            // 
            this.filterOptionsGBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterOptionsGBox.Controls.Add(this.filterBtn);
            this.filterOptionsGBox.Controls.Add(this.datesGBox);
            this.filterOptionsGBox.Controls.Add(this.typeCBox);
            this.filterOptionsGBox.Controls.Add(this.surnameCBox);
            this.filterOptionsGBox.Controls.Add(this.nameCBox);
            this.filterOptionsGBox.Controls.Add(this.typeLbl);
            this.filterOptionsGBox.Controls.Add(this.custSurnameLbl);
            this.filterOptionsGBox.Controls.Add(this.custNameLbl);
            this.filterOptionsGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterOptionsGBox.Location = new System.Drawing.Point(580, 79);
            this.filterOptionsGBox.Name = "filterOptionsGBox";
            this.filterOptionsGBox.Size = new System.Drawing.Size(237, 343);
            this.filterOptionsGBox.TabIndex = 9;
            this.filterOptionsGBox.TabStop = false;
            this.filterOptionsGBox.Text = "Filtering Options";
            // 
            // filterBtn
            // 
            this.filterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.filterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.filterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.Location = new System.Drawing.Point(115, 174);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(104, 23);
            this.filterBtn.TabIndex = 6;
            this.filterBtn.Text = "Apply Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // datesGBox
            // 
            this.datesGBox.Controls.Add(this.andLabel);
            this.datesGBox.Controls.Add(this.endDatePicker);
            this.datesGBox.Controls.Add(this.startDatePicker);
            this.datesGBox.Location = new System.Drawing.Point(19, 213);
            this.datesGBox.Name = "datesGBox";
            this.datesGBox.Size = new System.Drawing.Size(200, 110);
            this.datesGBox.TabIndex = 6;
            this.datesGBox.TabStop = false;
            this.datesGBox.Text = "Between Dates";
            // 
            // andLabel
            // 
            this.andLabel.AutoSize = true;
            this.andLabel.Location = new System.Drawing.Point(93, 51);
            this.andLabel.Name = "andLabel";
            this.andLabel.Size = new System.Drawing.Size(25, 13);
            this.andLabel.TabIndex = 4;
            this.andLabel.Text = "and";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(24, 76);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(159, 20);
            this.endDatePicker.TabIndex = 5;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(24, 19);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(159, 20);
            this.startDatePicker.TabIndex = 4;
            // 
            // typeCBox
            // 
            this.typeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCBox.FormattingEnabled = true;
            this.typeCBox.Location = new System.Drawing.Point(115, 129);
            this.typeCBox.Name = "typeCBox";
            this.typeCBox.Size = new System.Drawing.Size(104, 21);
            this.typeCBox.TabIndex = 3;
            // 
            // surnameCBox
            // 
            this.surnameCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.surnameCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.surnameCBox.FormattingEnabled = true;
            this.surnameCBox.Location = new System.Drawing.Point(115, 88);
            this.surnameCBox.Name = "surnameCBox";
            this.surnameCBox.Size = new System.Drawing.Size(104, 21);
            this.surnameCBox.TabIndex = 2;
            // 
            // nameCBox
            // 
            this.nameCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.nameCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.nameCBox.FormattingEnabled = true;
            this.nameCBox.Location = new System.Drawing.Point(115, 47);
            this.nameCBox.Name = "nameCBox";
            this.nameCBox.Size = new System.Drawing.Size(104, 21);
            this.nameCBox.TabIndex = 1;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(22, 142);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(93, 13);
            this.typeLbl.TabIndex = 2;
            this.typeLbl.Text = "Transaction Type:";
            // 
            // custSurnameLbl
            // 
            this.custSurnameLbl.AutoSize = true;
            this.custSurnameLbl.Location = new System.Drawing.Point(16, 96);
            this.custSurnameLbl.Name = "custSurnameLbl";
            this.custSurnameLbl.Size = new System.Drawing.Size(99, 13);
            this.custSurnameLbl.TabIndex = 1;
            this.custSurnameLbl.Text = "Customer Surname:";
            // 
            // custNameLbl
            // 
            this.custNameLbl.AutoSize = true;
            this.custNameLbl.Location = new System.Drawing.Point(30, 50);
            this.custNameLbl.Name = "custNameLbl";
            this.custNameLbl.Size = new System.Drawing.Size(85, 13);
            this.custNameLbl.TabIndex = 0;
            this.custNameLbl.Text = "Customer Name:";
            // 
            // TransactionsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(842, 473);
            this.Controls.Add(this.filterOptionsGBox);
            this.Controls.Add(this.transactListView);
            this.Controls.Add(this.transactReportLbl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.transactReportMenuStrip);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionsReportForm";
            this.Text = "Transactions Report";
            this.transactReportMenuStrip.ResumeLayout(false);
            this.transactReportMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.filterOptionsGBox.ResumeLayout(false);
            this.filterOptionsGBox.PerformLayout();
            this.datesGBox.ResumeLayout(false);
            this.datesGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip transactReportMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label transactReportLbl;
        private System.Windows.Forms.ListView transactListView;
        private System.Windows.Forms.ColumnHeader custIdCol;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader surnameCol;
        private System.Windows.Forms.ColumnHeader amtCol;
        private System.Windows.Forms.ColumnHeader dateCol;
        private System.Windows.Forms.ColumnHeader typeCol;
        private System.Windows.Forms.GroupBox filterOptionsGBox;
        private System.Windows.Forms.GroupBox datesGBox;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.ComboBox typeCBox;
        private System.Windows.Forms.ComboBox surnameCBox;
        private System.Windows.Forms.ComboBox nameCBox;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label custSurnameLbl;
        private System.Windows.Forms.Label custNameLbl;
        private System.Windows.Forms.Label andLabel;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.ToolStripMenuItem viewTotalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}