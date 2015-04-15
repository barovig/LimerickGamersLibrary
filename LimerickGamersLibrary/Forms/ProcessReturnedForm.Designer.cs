namespace LimerickGamersLibrary.Forms
{
    partial class ProcessReturnedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessReturnedForm));
            this.returnsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processReturnsLbl = new System.Windows.Forms.Label();
            this.gamesListView = new System.Windows.Forms.ListView();
            this.itemIdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gameNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custSurnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rentDateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showCustomerOrdersGBox = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.showCustOrdersBtn = new System.Windows.Forms.Button();
            this.surnameCBox = new System.Windows.Forms.ComboBox();
            this.nameCBox = new System.Windows.Forms.ComboBox();
            this.custSurnameLbl = new System.Windows.Forms.Label();
            this.custNameLbl = new System.Windows.Forms.Label();
            this.returnGameBtn = new System.Windows.Forms.Button();
            this.returnsMenuStrip.SuspendLayout();
            this.showCustomerOrdersGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnsMenuStrip
            // 
            this.returnsMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.returnsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.returnsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.returnsMenuStrip.Name = "returnsMenuStrip";
            this.returnsMenuStrip.Size = new System.Drawing.Size(842, 24);
            this.returnsMenuStrip.TabIndex = 3;
            this.returnsMenuStrip.Text = "Process Returns Menu";
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
            // processReturnsLbl
            // 
            this.processReturnsLbl.AutoSize = true;
            this.processReturnsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processReturnsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.processReturnsLbl.Location = new System.Drawing.Point(339, 35);
            this.processReturnsLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.processReturnsLbl.Name = "processReturnsLbl";
            this.processReturnsLbl.Size = new System.Drawing.Size(150, 25);
            this.processReturnsLbl.TabIndex = 4;
            this.processReturnsLbl.Text = "Return Games";
            // 
            // gamesListView
            // 
            this.gamesListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gamesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemIdCol,
            this.gameNameCol,
            this.custNameCol,
            this.custSurnameCol,
            this.rentDateCol});
            this.gamesListView.FullRowSelect = true;
            this.gamesListView.GridLines = true;
            this.gamesListView.HideSelection = false;
            this.gamesListView.Location = new System.Drawing.Point(28, 79);
            this.gamesListView.MultiSelect = false;
            this.gamesListView.Name = "gamesListView";
            this.gamesListView.Size = new System.Drawing.Size(528, 343);
            this.gamesListView.TabIndex = 5;
            this.gamesListView.UseCompatibleStateImageBehavior = false;
            this.gamesListView.View = System.Windows.Forms.View.Details;
            this.gamesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.gamesListView_ItemSelectionChanged);
            this.gamesListView.SelectedIndexChanged += new System.EventHandler(this.gamesListView_SelectedIndexChanged);
            // 
            // itemIdCol
            // 
            this.itemIdCol.Text = "Item ID";
            // 
            // gameNameCol
            // 
            this.gameNameCol.Text = "Game Name";
            this.gameNameCol.Width = 119;
            // 
            // custNameCol
            // 
            this.custNameCol.Text = "Customer Name";
            this.custNameCol.Width = 128;
            // 
            // custSurnameCol
            // 
            this.custSurnameCol.Text = "Customer Surname";
            this.custSurnameCol.Width = 131;
            // 
            // rentDateCol
            // 
            this.rentDateCol.Text = "Rent Date";
            this.rentDateCol.Width = 86;
            // 
            // showCustomerOrdersGBox
            // 
            this.showCustomerOrdersGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showCustomerOrdersGBox.Controls.Add(this.clearBtn);
            this.showCustomerOrdersGBox.Controls.Add(this.showCustOrdersBtn);
            this.showCustomerOrdersGBox.Controls.Add(this.surnameCBox);
            this.showCustomerOrdersGBox.Controls.Add(this.nameCBox);
            this.showCustomerOrdersGBox.Controls.Add(this.custSurnameLbl);
            this.showCustomerOrdersGBox.Controls.Add(this.custNameLbl);
            this.showCustomerOrdersGBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCustomerOrdersGBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.showCustomerOrdersGBox.Location = new System.Drawing.Point(581, 79);
            this.showCustomerOrdersGBox.Name = "showCustomerOrdersGBox";
            this.showCustomerOrdersGBox.Size = new System.Drawing.Size(237, 204);
            this.showCustomerOrdersGBox.TabIndex = 10;
            this.showCustomerOrdersGBox.TabStop = false;
            this.showCustomerOrdersGBox.Text = "Show Customer\'s Orders";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.clearBtn.Location = new System.Drawing.Point(135, 146);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(84, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // showCustOrdersBtn
            // 
            this.showCustOrdersBtn.BackColor = System.Drawing.Color.White;
            this.showCustOrdersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.showCustOrdersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.showCustOrdersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.showCustOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCustOrdersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.showCustOrdersBtn.Location = new System.Drawing.Point(19, 146);
            this.showCustOrdersBtn.Name = "showCustOrdersBtn";
            this.showCustOrdersBtn.Size = new System.Drawing.Size(84, 23);
            this.showCustOrdersBtn.TabIndex = 6;
            this.showCustOrdersBtn.Text = "Show";
            this.showCustOrdersBtn.UseVisualStyleBackColor = false;
            this.showCustOrdersBtn.Click += new System.EventHandler(this.showCustOrdersBtn_Click);
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
            // returnGameBtn
            // 
            this.returnGameBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnGameBtn.BackColor = System.Drawing.Color.White;
            this.returnGameBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.returnGameBtn.FlatAppearance.BorderSize = 3;
            this.returnGameBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.returnGameBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.returnGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnGameBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.returnGameBtn.Location = new System.Drawing.Point(655, 343);
            this.returnGameBtn.Name = "returnGameBtn";
            this.returnGameBtn.Size = new System.Drawing.Size(75, 47);
            this.returnGameBtn.TabIndex = 12;
            this.returnGameBtn.Text = "Return Game";
            this.returnGameBtn.UseVisualStyleBackColor = false;
            this.returnGameBtn.Click += new System.EventHandler(this.returnGameBtn_Click);
            // 
            // ProcessReturnedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(842, 473);
            this.Controls.Add(this.returnGameBtn);
            this.Controls.Add(this.showCustomerOrdersGBox);
            this.Controls.Add(this.gamesListView);
            this.Controls.Add(this.processReturnsLbl);
            this.Controls.Add(this.returnsMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "ProcessReturnedForm";
            this.Text = "Return Games";
            this.returnsMenuStrip.ResumeLayout(false);
            this.returnsMenuStrip.PerformLayout();
            this.showCustomerOrdersGBox.ResumeLayout(false);
            this.showCustomerOrdersGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip returnsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label processReturnsLbl;
        private System.Windows.Forms.ListView gamesListView;
        private System.Windows.Forms.ColumnHeader itemIdCol;
        private System.Windows.Forms.ColumnHeader gameNameCol;
        private System.Windows.Forms.ColumnHeader custNameCol;
        private System.Windows.Forms.ColumnHeader custSurnameCol;
        private System.Windows.Forms.ColumnHeader rentDateCol;
        private System.Windows.Forms.GroupBox showCustomerOrdersGBox;
        private System.Windows.Forms.Button showCustOrdersBtn;
        private System.Windows.Forms.ComboBox surnameCBox;
        private System.Windows.Forms.ComboBox nameCBox;
        private System.Windows.Forms.Label custSurnameLbl;
        private System.Windows.Forms.Label custNameLbl;
        private System.Windows.Forms.Button returnGameBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}