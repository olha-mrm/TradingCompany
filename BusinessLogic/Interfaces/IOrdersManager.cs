using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLogic.Interfaces
{
    public interface IOrdersManager
    {
        OrderDTO ChangeOrderStatus(long orderId, short statusId, long changedBy);
        OrderDTO GetOrderById(long id);
        List<OrderDTO> GetAllOrders();
        List<OrderDTO> FindOrdersByUser(long userId);
        List<OrderDTO> FindOrdersByItem(long itemId);
        List<OrderDTO> SortOrdersByStatuses();
        List<OrderDTO> SortOrdersByLastUpdate();
        List<OrdersRefDTO> GetItemsInOrder(long id);
        ItemDTO GetItemById(long id);
        string GetItemNameById(long id);
        string GetUsersFullNameById(long id);
        long GetUserIdByUsername(string username);
        string GetStatusName(short id);
        long GetItemIdByIdTitle(string title);
    }
}
