namespace LimerickGamersLibrary.Forms
{
    partial class ChangePasswordForm
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
            this.oldPswdLabel = new System.Windows.Forms.Label();
            this.newPswdLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oldTbox = new System.Windows.Forms.TextBox();
            this.newTbox = new System.Windows.Forms.TextBox();
            this.repeatNewTbox = new System.Windows.Forms.TextBox();
            this.changePswdLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPswdLabel
            // 
            this.oldPswdLabel.AutoSize = true;
            this.oldPswdLabel.Location = new System.Drawing.Point(85, 134);
            this.oldPswdLabel.Name = "oldPswdLabel";
            this.oldPswdLabel.Size = new System.Drawing.Size(75, 13);
            this.oldPswdLabel.TabIndex = 0;
            this.oldPswdLabel.Text = "Old Password:";
            // 
            // newPswdLbl
            // 
            this.newPswdLbl.AutoSize = true;
            this.newPswdLbl.Location = new System.Drawing.Point(79, 160);
            this.newPswdLbl.Name = "newPswdLbl";
            this.newPswdLbl.Size = new System.Drawing.Size(81, 13);
            this.newPswdLbl.TabIndex = 0;
            this.newPswdLbl.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Repeat New Password:";
            // 
            // oldTbox
            // 
            this.oldTbox.Location = new System.Drawing.Point(166, 131);
            this.oldTbox.Name = "oldTbox";
            this.oldTbox.PasswordChar = '*';
            this.oldTbox.Size = new System.Drawing.Size(100, 20);
            this.oldTbox.TabIndex = 1;
            // 
            // newTbox
            // 
            this.newTbox.Location = new System.Drawing.Point(166, 157);
            this.newTbox.Name = "newTbox";
            this.newTbox.PasswordChar = '*';
            this.newTbox.Size = new System.Drawing.Size(100, 20);
            this.newTbox.TabIndex = 2;
            this.newTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newTbox_KeyDown);
            // 
            // repeatNewTbox
            // 
            this.repeatNewTbox.Location = new System.Drawing.Point(166, 183);
            this.repeatNewTbox.Name = "repeatNewTbox";
            this.repeatNewTbox.PasswordChar = '*';
            this.repeatNewTbox.Size = new System.Drawing.Size(100, 20);
            this.repeatNewTbox.TabIndex = 3;
            this.repeatNewTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.repeatNewTbox_KeyDown);
            // 
            // changePswdLbl
            // 
            this.changePswdLbl.AutoSize = true;
            this.changePswdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePswdLbl.Location = new System.Drawing.Point(97, 35);
            this.changePswdLbl.Name = "changePswdLbl";
            this.changePswdLbl.Size = new System.Drawing.Size(130, 18);
            this.changePswdLbl.TabIndex = 16;
            this.changePswdLbl.Text = "Change Password";
            this.changePswdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okBtn
            // 
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.okBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Location = new System.Drawing.Point(82, 264);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(166, 264);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(336, 345);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.changePswdLbl);
            this.Controls.Add(this.repeatNewTbox);
            this.Controls.Add(this.newTbox);
            this.Controls.Add(this.oldTbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPswdLbl);
            this.Controls.Add(this.oldPswdLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldPswdLabel;
        private System.Windows.Forms.Label newPswdLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox oldTbox;
        private System.Windows.Forms.TextBox newTbox;
        private System.Windows.Forms.TextBox repeatNewTbox;
        private System.Windows.Forms.Label changePswdLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}