using System;
using System.Collections.Generic;
using DTO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IOrderDal
    {
        List<OrderDTO> GetAllOrders();
        OrderDTO GetOrderByID(long orderID);

        // TO DO !!!
        //OrderDTO SetOrderStatus(OrderDTO order, short new_status);
    }
}
