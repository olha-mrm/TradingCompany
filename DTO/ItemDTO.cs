using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ItemDTO
    {
        public long ItemID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int av_amount { get; set; }
    }
}
