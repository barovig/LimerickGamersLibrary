namespace LimerickGamersLibrary.Forms
{
    partial class ConfirmIssueGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmIssueGame));
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.custIDTb = new System.Windows.Forms.TextBox();
            this.custNameTb = new System.Windows.Forms.TextBox();
            this.custSurnameTb = new System.Windows.Forms.TextBox();
            this.gameNameTb = new System.Windows.Forms.TextBox();
            this.platformTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(200, 212);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Surname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Game Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Platform :";
            // 
            // custIDTb
            // 
            this.custIDTb.Location = new System.Drawing.Point(142, 63);
            this.custIDTb.Name = "custIDTb";
            this.custIDTb.Size = new System.Drawing.Size(133, 20);
            this.custIDTb.TabIndex = 7;
            // 
            // custNameTb
            // 
            this.custNameTb.Location = new System.Drawing.Point(142, 89);
            this.custNameTb.Name = "custNameTb";
            this.custNameTb.Size = new System.Drawing.Size(133, 20);
            this.custNameTb.TabIndex = 8;
            // 
            // custSurnameTb
            // 
            this.custSurnameTb.Location = new System.Drawing.Point(142, 119);
            this.custSurnameTb.Name = "custSurnameTb";
            this.custSurnameTb.Size = new System.Drawing.Size(133, 20);
            this.custSurnameTb.TabIndex = 9;
            // 
            // gameNameTb
            // 
            this.gameNameTb.Location = new System.Drawing.Point(142, 146);
            this.gameNameTb.Name = "gameNameTb";
            this.gameNameTb.Size = new System.Drawing.Size(133, 20);
            this.gameNameTb.TabIndex = 10;
            // 
            // platformTb
            // 
            this.platformTb.Location = new System.Drawing.Point(142, 173);
            this.platformTb.Name = "platformTb";
            this.platformTb.Size = new System.Drawing.Size(133, 20);
            this.platformTb.TabIndex = 11;
            // 
            // ConfirmIssueGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(287, 248);
            this.Controls.Add(this.platformTb);
            this.Controls.Add(this.gameNameTb);
            this.Controls.Add(this.custSurnameTb);
            this.Controls.Add(this.custNameTb);
            this.Controls.Add(this.custIDTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmIssueGame";
            this.Text = "ConfirmIssueGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custIDTb;
        private System.Windows.Forms.TextBox custNameTb;
        private System.Windows.Forms.TextBox custSurnameTb;
        private System.Windows.Forms.TextBox gameNameTb;
        private System.Windows.Forms.TextBox platformTb;
    }
}