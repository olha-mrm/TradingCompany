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
        OrderDTO CreateOrder(OrderDTO order);
        OrderDTO UpdateOrder(OrderDTO order);
        OrderDTO GetOrderByID(long orderID);
        List<OrderDTO> GetAllOrders();
        List<OrderDTO> GetOrdersByUserId(long customerID);
        // TO DO !!!
        //OrderDTO SetOrderStatus(OrderDTO order, short new_status);
    }
}
