using BusinessLogic.Interfaces;
using CompanyWPF.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CompanyWPF.ViewModels
{
    public class OrderListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        private IOrdersManager _orderManager;
        private ObservableCollection<MyOrder> _orderList;
        public OrderListViewModel(IOrdersManager ordersManager)
        {
            _orderManager = ordersManager;
            Update();
        }
        public ObservableCollection<MyOrder> OrderList
        {
            get { return _orderList; }
            set { _orderList = value; }
        }

        public void Update()
        {
            OrderList = new ObservableCollection<MyOrder>(GetMyOrders());
        }

        public List<MyOrder> GetMyOrders()
        {
            var myList = _orderManager.GetAllOrders();
            return ToMyOrderList(myList);
        }
        public MyOrder ToMyOrder(OrderDTO o)
        {
            return new MyOrder
            {
                ID = o.MainOrderID,
                FullName = _orderManager.GetUsersFullNameById(o.CustomerID),
                Status = _orderManager.GetStatusName(o.StatusID),
                Date = o.Date,
                LastStaffUpdated = _orderManager.GetUsersFullNameById(o.LastStaffUpdated == null ? 0 : o.LastStaffUpdated.Value),
                LastUpdate = o.LastUpdate,
                Comments = o.Comments
            };
        }

        public List<MyOrder> ToMyOrderList(List<OrderDTO> list)
        {
            var newList = new List<MyOrder>();
            foreach (OrderDTO o in list)
            {
                newList.Add(new MyOrder
                {
                    ID = o.MainOrderID,
                    FullName = _orderManager.GetUsersFullNameById(o.CustomerID),
                    Status = _orderManager.GetStatusName(o.StatusID),
                    Date = o.Date,
                    LastStaffUpdated = _orderManager.GetUsersFullNameById(o.LastStaffUpdated == null ? 0 : o.LastStaffUpdated.Value),
                    LastUpdate = o.LastUpdate,
                    Comments = o.Comments
                });
            }
            return newList;
        }

    }
}
