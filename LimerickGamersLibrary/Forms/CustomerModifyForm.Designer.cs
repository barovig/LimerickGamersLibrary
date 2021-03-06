﻿namespace LimerickGamersLibrary.Forms
{
    partial class CustomerModifyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerModifyForm));
            this.confMsg = new System.Windows.Forms.Label();
            this.customerMobileTB = new System.Windows.Forms.TextBox();
            this.customerEmailTB = new System.Windows.Forms.TextBox();
            this.customerAddressTB = new System.Windows.Forms.TextBox();
            this.customerSurnameTB = new System.Windows.Forms.TextBox();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confMsg
            // 
            this.confMsg.AutoSize = true;
            this.confMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confMsg.Location = new System.Drawing.Point(105, 13);
            this.confMsg.Name = "confMsg";
            this.confMsg.Size = new System.Drawing.Size(103, 18);
            this.confMsg.TabIndex = 60;
            this.confMsg.Text = "Edit Customer";
            this.confMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerMobileTB
            // 
            this.customerMobileTB.Location = new System.Drawing.Point(133, 207);
            this.customerMobileTB.Name = "customerMobileTB";
            this.customerMobileTB.Size = new System.Drawing.Size(174, 20);
            this.customerMobileTB.TabIndex = 59;
            // 
            // customerEmailTB
            // 
            this.customerEmailTB.Location = new System.Drawing.Point(133, 181);
            this.customerEmailTB.Name = "customerEmailTB";
            this.customerEmailTB.Size = new System.Drawing.Size(174, 20);
            this.customerEmailTB.TabIndex = 58;
            // 
            // customerAddressTB
            // 
            this.customerAddressTB.Location = new System.Drawing.Point(133, 98);
            this.customerAddressTB.Multiline = true;
            this.customerAddressTB.Name = "customerAddressTB";
            this.customerAddressTB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerAddressTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customerAddressTB.Size = new System.Drawing.Size(174, 77);
            this.customerAddressTB.TabIndex = 57;
            // 
            // customerSurnameTB
            // 
            this.customerSurnameTB.Location = new System.Drawing.Point(133, 72);
            this.customerSurnameTB.Name = "customerSurnameTB";
            this.customerSurnameTB.Size = new System.Drawing.Size(174, 20);
            this.customerSurnameTB.TabIndex = 56;
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(133, 46);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(174, 20);
            this.customerNameTB.TabIndex = 55;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(232, 258);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.ApplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.ApplyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Location = new System.Drawing.Point(133, 258);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 53;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Mobile Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Surname :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "First Name :";
            // 
            // CustomerModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(327, 300);
            this.Controls.Add(this.confMsg);
            this.Controls.Add(this.customerMobileTB);
            this.Controls.Add(this.customerEmailTB);
            this.Controls.Add(this.customerAddressTB);
            this.Controls.Add(this.customerSurnameTB);
            this.Controls.Add(this.customerNameTB);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerModifyForm";
            this.Text = "Delete Customer Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confMsg;
        private System.Windows.Forms.TextBox customerMobileTB;
        private System.Windows.Forms.TextBox customerEmailTB;
        private System.Windows.Forms.TextBox customerAddressTB;
        private System.Windows.Forms.TextBox customerSurnameTB;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}