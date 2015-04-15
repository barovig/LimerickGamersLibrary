namespace LimerickGamersLibrary.Forms
{
    partial class AddStaff
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameTbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.empTypeGbox = new System.Windows.Forms.GroupBox();
            this.managerRBtn = new System.Windows.Forms.RadioButton();
            this.staffRBtn = new System.Windows.Forms.RadioButton();
            this.empTypeGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // surnameTbox
            // 
            this.surnameTbox.Location = new System.Drawing.Point(322, 170);
            this.surnameTbox.Name = "surnameTbox";
            this.surnameTbox.Size = new System.Drawing.Size(100, 20);
            this.surnameTbox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Firstname";
            // 
            // nameTbox
            // 
            this.nameTbox.Location = new System.Drawing.Point(322, 109);
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(100, 20);
            this.nameTbox.TabIndex = 1;
            this.nameTbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // empTypeGbox
            // 
            this.empTypeGbox.Controls.Add(this.staffRBtn);
            this.empTypeGbox.Controls.Add(this.managerRBtn);
            this.empTypeGbox.Location = new System.Drawing.Point(279, 213);
            this.empTypeGbox.Name = "empTypeGbox";
            this.empTypeGbox.Size = new System.Drawing.Size(143, 67);
            this.empTypeGbox.TabIndex = 10;
            this.empTypeGbox.TabStop = false;
            this.empTypeGbox.Text = "Select Employee Type";
            // 
            // managerRBtn
            // 
            this.managerRBtn.AutoSize = true;
            this.managerRBtn.Location = new System.Drawing.Point(16, 30);
            this.managerRBtn.Name = "managerRBtn";
            this.managerRBtn.Size = new System.Drawing.Size(67, 17);
            this.managerRBtn.TabIndex = 3;
            this.managerRBtn.TabStop = true;
            this.managerRBtn.Text = "Manager";
            this.managerRBtn.UseVisualStyleBackColor = true;
            // 
            // staffRBtn
            // 
            this.staffRBtn.AutoSize = true;
            this.staffRBtn.Location = new System.Drawing.Point(89, 30);
            this.staffRBtn.Name = "staffRBtn";
            this.staffRBtn.Size = new System.Drawing.Size(47, 17);
            this.staffRBtn.TabIndex = 4;
            this.staffRBtn.TabStop = true;
            this.staffRBtn.Text = "Staff";
            this.staffRBtn.UseVisualStyleBackColor = true;
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 432);
            this.Controls.Add(this.empTypeGbox);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.surnameTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.empTypeGbox.ResumeLayout(false);
            this.empTypeGbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnameTbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.GroupBox empTypeGbox;
        private System.Windows.Forms.RadioButton staffRBtn;
        private System.Windows.Forms.RadioButton managerRBtn;
    }
}