using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //it should be DeliveryStatus* actually, I know :)
    public class DeliveryStatuDTO
    {
        public short DeliveryStatusID { get; set; }
        public string Status { get; set; }
    }
}
