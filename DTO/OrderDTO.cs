using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderDTO
    {
        public long MainOrderID { get; set; }
        public System.DateTime Date { get; set; }
        public long CustomerID { get; set; }
        public short StatusID { get; set; }
        public string Comments { get; set; }
        public System.DateTime LastUpdate { get; set; }
        public Nullable<long> LastStaffUpdated { get; set; }
    }
}
