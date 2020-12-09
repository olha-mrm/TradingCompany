using DTO;
using BusinessLogic.Interfaces;
using DAL.Interfaces;
using DALEF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class OrdersManager : IOrdersManager
    {
        private readonly UserDalEf _userDal;
        private readonly OrderDalEf _orderDal;
        private readonly OrdersRefDalEf _orderRefDal;
        private readonly DeliveryStatuDalEf _delStDal;
        private readonly ItemDalEf _itemDal;
        public OrdersManager(UserDalEf _userDal, 
            OrderDalEf _orderDal,
            OrdersRefDalEf _orderRedDal,
            DeliveryStatuDalEf _delStDal,
            ItemDalEf _itemDal)
        {
            this._userDal = _userDal;
            this._orderDal = _orderDal;
            this._orderRefDal = _orderRedDal;
            this._delStDal = _delStDal;
            this._itemDal = _itemDal;
        }

        public OrderDTO ChangeOrderStatus(long orderId, short statusId, long changedBy)
        {
            OrderDTO order = _orderDal.GetOrderByID(orderId);
            order.StatusID = statusId;
            order.LastStaffUpdated = changedBy;
            order.LastUpdate = DateTime.UtcNow;
            return _orderDal.UpdateOrder(order);
        }

        public List<OrderDTO> GetAllOrders()
        {
            return _orderDal.GetAllOrders();
        }

        public List<OrderDTO> FindOrdersByUser(long userId)
        {
            List<OrderDTO> myList = _orderDal.GetOrdersByUserId(userId);
            return myList;
        }

        public List<OrderDTO> FindOrdersByItem(long itemId)
        {
            List<OrderDTO> myList = new List<OrderDTO>();
            if (itemId == 0) return myList;
            List<OrdersRefDTO> itemsinlist = _orderRefDal.GetOrdersByItem(itemId);
            foreach (var i in itemsinlist)
            {
                myList.Add(_orderDal.GetOrderByID(i.refOrderID));
            }
            return myList;
        }

        public List<OrderDTO> SortOrdersByStatuses()
        {            
            List<OrderDTO> orders = _orderDal.GetAllOrders().OrderBy(o => o.StatusID).ToList();
            return orders;
        }
        public List<OrderDTO> SortOrdersByLastUpdate()
        {
            return _orderDal.GetAllOrders().OrderBy(o => o.LastUpdate).ToList();
        }
        public List<OrdersRefDTO> GetItemsInOrder(long id)
        {
            return _orderRefDal.GetItemsInOrder(id);
        }
        public string GetItemNameById(long id)
        {
            return _itemDal.GetNameByID(id);
        }
        public string GetUsersFullNameById(long id)
        {
            return id > 0 ? _userDal.GetUserById(id).FullName : "no one";
        }
        public long GetUserIdByUsername(string username)
        {
            return _userDal.GetUserId(username);
        }
        public string GetStatusName(short id)
        {
            return _delStDal.GetStatusNameById(id);
        }
        public long GetItemIdByIdTitle(string title)
        {
            var item = _itemDal.GetItemByTitle(title);
            return item is null ? 0 : item.ItemID;           
        }

        public OrderDTO GetOrderById(long id)
        {
            var order = _orderDal.GetOrderByID(id);
            return order;
        }

        public ItemDTO GetItemById(long id)
        {
            return _itemDal.GetItemById(id);
        }
    }
}