using System;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
    public class Order
    {
        public string CustomerId { set; get; }
        public string StockItem { set; get; }
        public DateTime DateRented { set; get; }
        public DateTime DateReturned { set; get; }

        public Order(string custId, string itemId, DateTime rented)
        {
            CustomerId = custId;
            StockItem = itemId;
            DateRented = rented;
        }
        public Order(string custId, string itemId, DateTime rented, DateTime returned)
        {
            CustomerId = custId;
            StockItem = itemId;
            DateRented = rented;
            DateReturned = returned;
        }
        public Order(string custId, string itemId)
        {
            CustomerId = custId;
            StockItem = itemId;

        }
    }
}
