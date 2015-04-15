using System;
using System.Collections.Generic;
using System.Linq;

namespace LimerickGamersLibrary.Class
{
    static class  Model
    {
        // Collections to store programs data
        public static List<Employee> employeeList = new List<Employee>();    
        public static List<Customer> customerList = new List<Customer>();
        public static List<Game> gameList = new List<Game>();
        public static List<Order> ordersList = new List<Order>();
        public static List<StockItem> stockList = new List<StockItem>();
        public static List<Transaction> transactList = new List<Transaction>();

        // Initialize Model from SerializableModel object
        public static void CopyFromSerialized(SerializableModel sModel)
        {
            employeeList = sModel.employeeList;
            customerList = sModel.customerList;
            gameList = sModel.gameList;
            ordersList = sModel.ordersList;
            stockList = sModel.stockList;
            transactList = sModel.transactList;
        }

        // Unique ID generators
        public static string GenerateEmployeeId()
        {
            // If list is empty - return id of 1
            if (employeeList.Count == 0)
                return "1";
            // Find employee with highest ID using LINQ
            var empWithMaxId = employeeList.Aggregate((agg, next) => int.Parse(next.EmployeeId) > int.Parse(agg.EmployeeId) ? next : agg);
            int maxId = int.Parse(empWithMaxId.EmployeeId);
            return Convert.ToString(maxId+1);
        }

        public static string GenerateCustomerId()
        {
            if (customerList.Count == 0)
                return "1";
            var custWithMaxId = customerList.Aggregate((agg, next) => int.Parse(next.CustomerId) > int.Parse(agg.CustomerId) ? next : agg);
            int maxId = int.Parse(custWithMaxId.CustomerId);
            return Convert.ToString(maxId + 1);
            
        }

        public static string GenerateGameId()
        {
            if (gameList.Count == 0)
                return "1"; 
            var gameWithMaxId = gameList.Aggregate((agg, next) => int.Parse(next.GameId) > int.Parse(agg.GameId) ? next : agg);
            int maxId = int.Parse(gameWithMaxId.GameId);
            return Convert.ToString(maxId + 1);
            
        }

        public static string GenerateStockItemId()
        {
            if (stockList.Count == 0)
                return "1";
            var stockItemWithMaxId = stockList.Aggregate((agg, next) => int.Parse(next.ItemId) > int.Parse(agg.ItemId) ? next : agg);
            int maxId = int.Parse(stockItemWithMaxId.ItemId);
            return Convert.ToString(maxId + 1);
            
        }


    }
    [Serializable]
    class SerializableModel
    {
        public  List<Employee> employeeList { set; get; }
        public  List<Customer> customerList{ set; get; }
        public  List<Game> gameList{ set; get; }
        public  List<Order> ordersList{ set; get; }
        public  List<StockItem> stockList{ set; get; }
        public  List<Transaction> transactList{ set; get; }

        public SerializableModel()
        {
            employeeList = Model.employeeList;
            customerList = Model.customerList;
            gameList = Model.gameList;
            ordersList = Model.ordersList;
            stockList = Model.stockList;
            transactList = Model.transactList;
        }

        //public SerializableModel(List<Employee> eList, List<Customer> cList, List<Game> gList, List<Order> oList,
        //    List<StockItem> siList, List<Transaction> tList)
        //{
            
        //}
    }

}
