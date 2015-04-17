using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LimerickGamersLibrary.Class;

namespace LimerickGamersLibrary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        // Static variable to hold currently logged-in user
        public static Employee LoggedInUser;

    }

    public static class Extension
    {
        // Helper function that gathers all TextBoxes from the Control and returns IEnumerable<TextBox>
        public static IEnumerable<TextBox> GetChildTextBoxs(this Control control)
        {
            var children = (control.Controls != null) ? control.Controls.OfType<TextBox>() : Enumerable.Empty<TextBox>();
            return children.SelectMany(GetChildTextBoxs).Concat(children);
        }

        // Helper function that saves database to binary file. Returns True on success

        public static bool SaveDatabase()
        {
            ModelSerializer serializer = new ModelSerializer();
            // Default ctor will set sModel contents to contents of static Model
            SerializableModel sModel = new SerializableModel();
            try
            {
                serializer.SerializeStatic("database.dat", sModel);
                return true;
            }
            catch(Exception)
            {
                MessageBox.Show("Error saving database.");
            }
            return false;
        }

        public static bool LoadDatabase()
        {
            ModelSerializer serializer = new ModelSerializer();
            try
            {
                Model.CopyFromSerialized(serializer.DeserializeStatic("database.dat"));
                return true;
            }
            catch(Exception)
            {
                MessageBox.Show("Error opening database.");
            }
            return false;
        }


        public static void ReadStaff(string fileName)
        {
            string[] fileLines = File.ReadAllLines(fileName);

            for (int i = 1; i < fileLines.Count(); i++)
            {
                string[] lineItems = fileLines[i].Split(',');
                Staff emp = new Staff(lineItems[0], lineItems[1], lineItems[2], lineItems[3], lineItems[4]);
                Model.employeeList.Add(emp);
            }
        }

        public static void ReadCustomers(string fileName)
        {
            string[] fileLines = File.ReadAllLines(fileName);

            for (int i = 1; i < fileLines.Count(); i++)
            {
                string[] lineItems = fileLines[i].Split(',');
                Customer cust = new Customer(lineItems[0], lineItems[1], lineItems[2], lineItems[3], lineItems[4]);
                Model.customerList.Add(cust);
            }
        }

        public static void ReadGames(string fileName)
        {
            string[] fileLines = File.ReadAllLines(fileName);

            for (int i = 1; i < fileLines.Count(); i++)
            {
                string[] lineItems = fileLines[i].Split(',');
                Game game = new Game(lineItems[0], lineItems[1], lineItems[2], lineItems[3], lineItems[5], lineItems[6], (EsrbRating)Enum.Parse(typeof(EsrbRating),lineItems[4]));
                Model.gameList.Add(game);
            }
        }
        public static void ReadOrders(string fileName)
        {
            string[] fileLines = File.ReadAllLines(fileName);

            for (int i = 0; i < fileLines.Count(); i++)
            {
                string[] lineItems = fileLines[i].Split(',');
                
                Order order = new Order(lineItems[0],lineItems[1],ProcessShortDate(lineItems[2]), ProcessShortDate(lineItems[3]));
                Model.ordersList.Add(order);
            }
        }
        public static void ReadItems(string fileName)
        {
            string[] fileLines = File.ReadAllLines(fileName);

            for (int i = 0; i < fileLines.Count(); i++)
            {
                string[] lineItems = fileLines[i].Split(',');
                StockItem item = new StockItem(lineItems[0], lineItems[1], Convert.ToBoolean(lineItems[2]));
                Model.stockList.Add(item);
            }
        }
        public static void ReadTransactions(string fileName)
        {
            string[] fileLines = File.ReadAllLines(fileName);

            for (int i = 0; i < fileLines.Count(); i++)
            {
                string[] lineItems = fileLines[i].Split(',');
                Transaction transact = new Transaction(lineItems[0], double.Parse(lineItems[1]), ProcessShortDate(lineItems[2]), (AccountTransaction)Enum.Parse(typeof(AccountTransaction), lineItems[3])); 
                Model.transactList.Add(transact);
            }
        }

        public static DateTime ProcessShortDate(string date)
        {
            string[] dateItems = date.Split('/');
            int year = int.Parse(dateItems[2]);
            int month = int.Parse(dateItems[0]);
            int day = int.Parse(dateItems[1]);
            return new DateTime(year, month, day);
        }

        public static void ReadCsvFiles()
        {
            ReadOrders("Orders.csv");
            ReadTransactions("Transactions.csv");
            ReadItems("Items.csv");
            ReadCustomers("Customers.csv");
            ReadGames("Games.csv");
            ReadStaff("Staff.csv");
        }
    }

}
