namespace LimerickGamersLibrary
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.staffIdLbl = new System.Windows.Forms.Label();
            this.pswdLbl = new System.Windows.Forms.Label();
            this.idTbox = new System.Windows.Forms.TextBox();
            this.pswdTbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // staffIdLbl
            // 
            this.staffIdLbl.AutoSize = true;
            this.staffIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.staffIdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.staffIdLbl.Location = new System.Drawing.Point(331, 191);
            this.staffIdLbl.Name = "staffIdLbl";
            this.staffIdLbl.Size = new System.Drawing.Size(58, 17);
            this.staffIdLbl.TabIndex = 0;
            this.staffIdLbl.Text = "Staff ID:";
            // 
            // pswdLbl
            // 
            this.pswdLbl.AutoSize = true;
            this.pswdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.pswdLbl.Location = new System.Drawing.Point(316, 217);
            this.pswdLbl.Name = "pswdLbl";
            this.pswdLbl.Size = new System.Drawing.Size(73, 17);
            this.pswdLbl.TabIndex = 1;
            this.pswdLbl.Text = "Password:";
            // 
            // idTbox
            // 
            this.idTbox.Location = new System.Drawing.Point(395, 190);
            this.idTbox.Name = "idTbox";
            this.idTbox.Size = new System.Drawing.Size(100, 20);
            this.idTbox.TabIndex = 2;
            this.idTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idTbox_KeyDown);
            // 
            // pswdTbox
            // 
            this.pswdTbox.Location = new System.Drawing.Point(395, 216);
            this.pswdTbox.Name = "pswdTbox";
            this.pswdTbox.PasswordChar = '*';
            this.pswdTbox.Size = new System.Drawing.Size(100, 20);
            this.pswdTbox.TabIndex = 3;
            this.pswdTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pswdTbox_KeyDown);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.loginBtn.Location = new System.Drawing.Point(395, 242);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPicBox.Image")));
            this.logoPicBox.Location = new System.Drawing.Point(210, 74);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(430, 41);
            this.logoPicBox.TabIndex = 5;
            this.logoPicBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(842, 473);
            this.Controls.Add(this.logoPicBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pswdTbox);
            this.Controls.Add(this.idTbox);
            this.Controls.Add(this.pswdLbl);
            this.Controls.Add(this.staffIdLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Login";
            this.Text = "Limerick Gamers Library Login";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staffIdLbl;
        private System.Windows.Forms.Label pswdLbl;
        private System.Windows.Forms.TextBox idTbox;
        private System.Windows.Forms.TextBox pswdTbox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.PictureBox logoPicBox;
    }
}

