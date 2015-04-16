using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimerickGamersLibrary.Class
{
    [Serializable]
     public class ReserveGames : Order
    {
        public DateTime DateReserved { set; get; }

        public ReserveGames(DateTime reservedate, string custId, string itemId)
                        : base(custId, itemId)
        {

            this.DateReserved = reservedate;
        }
    }
}
