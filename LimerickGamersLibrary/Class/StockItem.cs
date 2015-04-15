
using System;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
    class StockItem
    {
        public string ItemId { set; get; }
        public string GameId { set; get; }
        public bool OnRent { set; get; }
        public StockItem(string id, string gameId)
        {
            ItemId = id; GameId = gameId;
            OnRent = false;
        }
        public StockItem(string gameId)
        {
            ItemId = Model.GenerateStockItemId();
            GameId = gameId;
            OnRent = false;
        }
        public StockItem(string gameId, bool onRent)
        {
            ItemId = Model.GenerateStockItemId();
            GameId = gameId;
            OnRent = onRent;
        }

        internal string[] ToStringArray()
        {
            return new string[]{ItemId, GameId, OnRent.ToString()};
        }

        public void ToggleRent()
        {
            OnRent = !OnRent;
        }
    }
}
