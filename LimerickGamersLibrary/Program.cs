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
                Game game = new Game(lineItems[0], lineItems[1], lineItems[2], lineItems[3], lineItems[4], lineItems[5], lineItems[6]);
                Model.gameList.Add(game);
            }
        }
    }

}
