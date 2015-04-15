namespace LimerickGamersLibrary.Forms
{
    partial class TransactTotalsReport
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
            this.timePeriodGBox = new System.Windows.Forms.GroupBox();
            this.showAllBtn = new System.Windows.Forms.RadioButton();
            this.yearRBtn = new System.Windows.Forms.RadioButton();
            this.monthRBtn = new System.Windows.Forms.RadioButton();
            this.memberFeeLbl = new System.Windows.Forms.Label();
            this.rentalFeeLbl = new System.Windows.Forms.Label();
            this.lateReturnFees = new System.Windows.Forms.Label();
            this.membershipFeeOutLbl = new System.Windows.Forms.Label();
            this.rentalFeeOutLbl = new System.Windows.Forms.Label();
            this.lateReturnFeeOutLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.confMsg = new System.Windows.Forms.Label();
            this.timePeriodGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePeriodGBox
            // 
            this.timePeriodGBox.Controls.Add(this.showAllBtn);
            this.timePeriodGBox.Controls.Add(this.yearRBtn);
            this.timePeriodGBox.Controls.Add(this.monthRBtn);
            this.timePeriodGBox.Location = new System.Drawing.Point(30, 192);
            this.timePeriodGBox.Name = "timePeriodGBox";
            this.timePeriodGBox.Size = new System.Drawing.Size(278, 71);
            this.timePeriodGBox.TabIndex = 0;
            this.timePeriodGBox.TabStop = false;
            this.timePeriodGBox.Text = "Show totals for";
            // 
            // showAllBtn
            // 
            this.showAllBtn.AutoSize = true;
            this.showAllBtn.Location = new System.Drawing.Point(186, 32);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(66, 17);
            this.showAllBtn.TabIndex = 2;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.CheckedChanged += new System.EventHandler(this.showAllBtn_CheckedChanged);
            // 
            // yearRBtn
            // 
            this.yearRBtn.AutoSize = true;
            this.yearRBtn.Location = new System.Drawing.Point(110, 32);
            this.yearRBtn.Name = "yearRBtn";
            this.yearRBtn.Size = new System.Drawing.Size(70, 17);
            this.yearRBtn.TabIndex = 1;
            this.yearRBtn.Text = "Last Year";
            this.yearRBtn.UseVisualStyleBackColor = true;
            this.yearRBtn.CheckedChanged += new System.EventHandler(this.yearRBtn_CheckedChanged);
            // 
            // monthRBtn
            // 
            this.monthRBtn.AutoSize = true;
            this.monthRBtn.Checked = true;
            this.monthRBtn.Location = new System.Drawing.Point(26, 32);
            this.monthRBtn.Name = "monthRBtn";
            this.monthRBtn.Size = new System.Drawing.Size(78, 17);
            this.monthRBtn.TabIndex = 0;
            this.monthRBtn.TabStop = true;
            this.monthRBtn.Text = "Last Month";
            this.monthRBtn.UseVisualStyleBackColor = true;
            this.monthRBtn.CheckedChanged += new System.EventHandler(this.monthRBtn_CheckedChanged);
            // 
            // memberFeeLbl
            // 
            this.memberFeeLbl.AutoSize = true;
            this.memberFeeLbl.Location = new System.Drawing.Point(97, 90);
            this.memberFeeLbl.Name = "memberFeeLbl";
            this.memberFeeLbl.Size = new System.Drawing.Size(93, 13);
            this.memberFeeLbl.TabIndex = 1;
            this.memberFeeLbl.Text = "Membership Fees:";
            // 
            // rentalFeeLbl
            // 
            this.rentalFeeLbl.AutoSize = true;
            this.rentalFeeLbl.Location = new System.Drawing.Point(123, 119);
            this.rentalFeeLbl.Name = "rentalFeeLbl";
            this.rentalFeeLbl.Size = new System.Drawing.Size(67, 13);
            this.rentalFeeLbl.TabIndex = 2;
            this.rentalFeeLbl.Text = "Rental Fees:";
            // 
            // lateReturnFees
            // 
            this.lateReturnFees.AutoSize = true;
            this.lateReturnFees.Location = new System.Drawing.Point(98, 151);
            this.lateReturnFees.Name = "lateReturnFees";
            this.lateReturnFees.Size = new System.Drawing.Size(92, 13);
            this.lateReturnFees.TabIndex = 3;
            this.lateReturnFees.Text = "Late Return Fees:";
            // 
            // membershipFeeOutLbl
            // 
            this.membershipFeeOutLbl.AutoSize = true;
            this.membershipFeeOutLbl.Location = new System.Drawing.Point(196, 90);
            this.membershipFeeOutLbl.Name = "membershipFeeOutLbl";
            this.membershipFeeOutLbl.Size = new System.Drawing.Size(13, 13);
            this.membershipFeeOutLbl.TabIndex = 4;
            this.membershipFeeOutLbl.Text = "0";
            // 
            // rentalFeeOutLbl
            // 
            this.rentalFeeOutLbl.AutoSize = true;
            this.rentalFeeOutLbl.Location = new System.Drawing.Point(196, 119);
            this.rentalFeeOutLbl.Name = "rentalFeeOutLbl";
            this.rentalFeeOutLbl.Size = new System.Drawing.Size(13, 13);
            this.rentalFeeOutLbl.TabIndex = 5;
            this.rentalFeeOutLbl.Text = "0";
            // 
            // lateReturnFeeOutLbl
            // 
            this.lateReturnFeeOutLbl.AutoSize = true;
            this.lateReturnFeeOutLbl.Location = new System.Drawing.Point(196, 151);
            this.lateReturnFeeOutLbl.Name = "lateReturnFeeOutLbl";
            this.lateReturnFeeOutLbl.Size = new System.Drawing.Size(13, 13);
            this.lateReturnFeeOutLbl.TabIndex = 6;
            this.lateReturnFeeOutLbl.Text = "0";
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.okBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.okBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(233)))), ((int)(((byte)(203)))));
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Location = new System.Drawing.Point(134, 290);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // confMsg
            // 
            this.confMsg.AutoSize = true;
            this.confMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confMsg.Location = new System.Drawing.Point(86, 23);
            this.confMsg.Name = "confMsg";
            this.confMsg.Size = new System.Drawing.Size(139, 18);
            this.confMsg.TabIndex = 15;
            this.confMsg.Text = "Transactions Totals";
            this.confMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TransactTotalsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(338, 347);
            this.ControlBox = false;
            this.Controls.Add(this.confMsg);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.lateReturnFeeOutLbl);
            this.Controls.Add(this.rentalFeeOutLbl);
            this.Controls.Add(this.membershipFeeOutLbl);
            this.Controls.Add(this.lateReturnFees);
            this.Controls.Add(this.rentalFeeLbl);
            this.Controls.Add(this.memberFeeLbl);
            this.Controls.Add(this.timePeriodGBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(9)))));
            this.Name = "TransactTotalsReport";
            this.ShowInTaskbar = false;
            this.Text = "Transactions Totals";
            this.timePeriodGBox.ResumeLayout(false);
            this.timePeriodGBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox timePeriodGBox;
        private System.Windows.Forms.RadioButton monthRBtn;
        private System.Windows.Forms.RadioButton showAllBtn;
        private System.Windows.Forms.RadioButton yearRBtn;
        private System.Windows.Forms.Label memberFeeLbl;
        private System.Windows.Forms.Label rentalFeeLbl;
        private System.Windows.Forms.Label lateReturnFees;
        private System.Windows.Forms.Label membershipFeeOutLbl;
        private System.Windows.Forms.Label rentalFeeOutLbl;
        private System.Windows.Forms.Label lateReturnFeeOutLbl;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label confMsg;
    }
}