using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class ReturnItemConfirmForm : Form
    {
        public ReturnItemConfirmForm()
        {
            InitializeComponent();
        }

        private List<string> OrderInfo;
        private int dayDifference;
        public ReturnItemConfirmForm(List<string> orderInfo)
        {
            InitializeComponent();

            itemIdTbox.Text = orderInfo[0];
            gameTbox.Text = orderInfo[1];
            nameTbox.Text = orderInfo[2];
            surnameTbox.Text = orderInfo[3];
            rentDateTbox.Text = orderInfo[4];
            returnDateTbox.Text = DateTime.Now.ToShortDateString();
            OrderInfo = orderInfo;
            dayDifference = 0;
        }

        public ReturnItemConfirmForm(List<string> orderInfo, int daysDiff)
        {
            InitializeComponent();

            itemIdTbox.Text = orderInfo[0];
            gameTbox.Text = orderInfo[1];
            nameTbox.Text = orderInfo[2];
            surnameTbox.Text = orderInfo[3];
            rentDateTbox.Text = orderInfo[4];
            returnDateTbox.Text = DateTime.Now.ToShortDateString();


            lateReturnMsgLabel.Text = "Late Return Fee: " + daysDiff.ToString() + " euros.";
            Point centerPoint = new Point(this.Width / 2 - lateReturnMsgLabel.Width / 2, lateReturnMsgLabel.Location.Y);
            lateReturnMsgLabel.Location = centerPoint;
            lateReturnMsgLabel.ForeColor = Color.Red;

            okBtn.Text = "Pay Fee";

            OrderInfo = orderInfo;
            dayDifference = daysDiff;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string custId = Model.customerList.Find(cust => cust.Name == OrderInfo[2] && cust.Surname == OrderInfo[3]).CustomerId;
            if (dayDifference > 3)
                Model.transactList.Add(new Transaction(custId, dayDifference, DateTime.Now, AccountTransaction.LateReturnFee));
            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
