using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.Interfaces
{
    public interface IOrdersRefDal
    {
        List<OrdersRefDTO> GetItemsInOrder(long orderID);
        List<OrdersRefDTO> GetOrdersByItem(long itemID);
    }
}