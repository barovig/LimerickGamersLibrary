using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary.Forms
{
    public partial class TransactionsReportForm : Form
    {
        public TransactionsReportForm()
        {
            // For testing add some transactions
            AddTestTransacts();

            InitializeComponent();

            //Populate ListView
            PopulateViewFromTransactList(Model.transactList);

            // Setup Combobox collections

            // Setup Name and Surname collections + autocomplete
            // Get all distinct names
            List<string> names =
                Model.customerList.GroupBy(cust => cust.Name).Select(name => name.First().Name).ToList();
            // Get all distinct surnames
            List<string> surnames =
                Model.customerList.GroupBy(cust => cust.Surname).Select(surname => surname.First().Surname).ToList();

            // Setup autocomplete source collections
            // For Names
            AutoCompleteStringCollection namesAcCollection = new AutoCompleteStringCollection();
            namesAcCollection.AddRange(names.ToArray());
            // For Surnames
            AutoCompleteStringCollection surnamesAcCollection = new AutoCompleteStringCollection();
            surnamesAcCollection.AddRange(surnames.ToArray());
            // Add AutoComplete collections to CBoxes
            nameCBox.AutoCompleteCustomSource = namesAcCollection;
            surnameCBox.AutoCompleteCustomSource = surnamesAcCollection;

            // Setup transaction types
            string[] typesArray = Enum.GetNames(typeof(AccountTransaction));
            List<string> types = new List<string>();
            types.AddRange(typesArray);
            types.Insert(0, "All");
            typeCBox.DataSource = types;
            // Get oldest and newest dates from Model.transactList
            DateTime oldest = new DateTime();
            oldest = Model.transactList.Min(transaction => transaction.TransactionDate);
            // Set start and end dates to oldest and newest
            startDatePicker.Value = oldest;
            endDatePicker.Value = DateTime.Now;
        }

        private void AddTestTransacts()
        {
            Model.transactList.Add(new Transaction("1", 3, new DateTime(2014, 03, 12), AccountTransaction.RentalFee));
            Model.transactList.Add(new Transaction("1", 3, new DateTime(2014, 03, 9), AccountTransaction.RentalFee));
            Model.transactList.Add(new Transaction("2", 20, new DateTime(2013, 05, 21), AccountTransaction.MembershipFee));
            Model.transactList.Add(new Transaction("2", 5, new DateTime(2014, 05, 7), AccountTransaction.LateReturnFee));
            Model.customerList.Add(new Customer("name 1", "surname 1"));
            Model.customerList.Add(new Customer("name2", "surname2"));
            Model.customerList.Add(new Customer("name 1", "surname 2"));
            Model.customerList.Add(new Customer("name2", "surname1"));
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.LoadDatabase();
            // Populates
            PopulateViewFromTransactList(Model.transactList);
        }

        private void saveDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension.SaveDatabase();
        }

        private void PopulateViewFromTransactList(List<Transaction> list)
        {
            transactListView.Items.Clear();
            transactListView.Items.AddRange(GenerateTransactViewItems(list));
        }

        private ListViewItem[] GenerateTransactViewItems(List<Transaction> transactList)
        {
            ListViewItem[] items = new ListViewItem[transactList.Count];
            int i = 0;
            foreach (string[] transactArray in transactList.Select(transact => new string[]
            {
                // Transaction ID
                transact.CustomerId,
                // Customer Name
                Model.customerList.Find(customer => customer.CustomerId == transact.CustomerId).Name,
                // Customer Surname
                Model.customerList.Find(customer => customer.CustomerId == transact.CustomerId).Surname,
                // Amount
                transact.Amount.ToString(),
                // Transaction Date
                transact.TransactionDate.ToShortDateString(),
                // Transaction Type
                Enum.GetName(typeof (AccountTransaction), transact.TransactionType)

            }))
            {
                // Add ListItem created from string[] array to collection of items
                items[i++] = new ListViewItem(transactArray);
            }
            return items;
        }

        private List<Transaction> ApplyTransactFiltering()
        {
            List<Transaction> returnList = new List<Transaction>();

            string filterName = nameCBox.Text;
            string filterSurname = surnameCBox.Text;
            string filterType = typeCBox.Text;
            DateTime filterStartDate = startDatePicker.Value;
            DateTime filterEndDate = endDatePicker.Value;

            // Get customer IDs where matching name and surname
            List<string> custIdList = new List<string>();
            foreach (var customer in Model.customerList)
            {
                if (
                        (customer.Name == filterName && filterSurname == "") ||
                        (customer.Surname == filterSurname && filterName == "") ||
                        (customer.Name == filterName && customer.Surname == filterSurname) ||
                        (filterName == "" && filterSurname == "")
                    )
                {
                    custIdList.Add(customer.CustomerId);
                }
            }

            foreach (var transact in Model.transactList)
            {
                if (
                    custIdList.Contains(transact.CustomerId) &&
                    (Enum.GetName(typeof(AccountTransaction), transact.TransactionType) == filterType ||
                     filterType == "All") &&
                    (filterStartDate <= transact.TransactionDate && transact.TransactionDate <= filterEndDate)
                    )
                {
                    returnList.Add(transact);
                }
            }
            return returnList;
        }


        private void filterBtn_Click(object sender, EventArgs e)
        {
            PopulateViewFromTransactList(ApplyTransactFiltering());
        }

        private void viewTotalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactTotalsReport totalsReport = new TransactTotalsReport();
            totalsReport.ShowDialog();
        }
    }
}
