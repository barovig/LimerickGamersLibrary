using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class TransactTotalsReport : Form
    {
        public TransactTotalsReport()
        {
            InitializeComponent();
        }

        private void monthRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (monthRBtn.Checked)
            {
                // Passes new DateTime obj set to 1st of current month current year
                CalculateUpdateTotals(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1));
            }
        }

        private void yearRBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (yearRBtn.Checked)
            {
                // Passes new DateTime obj set to 1st of January of current year
                CalculateUpdateTotals(new DateTime(DateTime.Now.Year, 1, 1));
            }
        }

        private void showAllBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (showAllBtn.Checked)
            {
                // Passes new DateTime obj set to 1st of January of 1 CE. It's a very old Gamers Library
                CalculateUpdateTotals(new DateTime(1,1,1));
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateUpdateTotals(DateTime startDate)
        {
            // C# construct that means:
            // get transactions FROM transactList WHERE (transactDate > startDate) AND (type = Membership Fee)
            // and then SUM all transact.Amount based on condition above
            double memberFees = Model.transactList.Where(
                transact =>
                    transact.TransactionDate > startDate && transact.TransactionType == AccountTransaction.MembershipFee)
                .Sum(transact => transact.Amount);
            // Repeat for Rental Fees
            double rentFees = Model.transactList.Where(
                transact =>
                    transact.TransactionDate > startDate && transact.TransactionType == AccountTransaction.RentalFee)
                .Sum(transact => transact.Amount);
            // Late Return Fee
            double lateFees = Model.transactList.Where(
                transact =>
                    transact.TransactionDate > startDate && transact.TransactionType == AccountTransaction.LateReturnFee)
                .Sum(transact => transact.Amount);

            // Set labels to amounts calculated
            
            // Remove decimal point by splitting string at it and taking the whole part (first elem in array returned by Split() )
            membershipFeeOutLbl.Text = memberFees.ToString().Split('.')[0];
            lateReturnFeeOutLbl.Text = lateFees.ToString().Split('.')[0];
            rentalFeeOutLbl.Text = rentFees.ToString().Split('.')[0];

        }


    }
}
