using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrdersRefDTO
    {
        public long refOrderID { get; set; }
        public long refItemID { get; set; }
        public int amount { get; set; }
    }
}
