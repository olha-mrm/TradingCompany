using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyWPF.Model
{
    public class MyOrder
    {
        public long ID { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string LastStaffUpdated { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Comments { get; set; }
    }
}