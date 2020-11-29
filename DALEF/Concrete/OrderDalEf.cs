using AutoMapper;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEF.Concrete
{
    public class OrderDalEf : IOrderDal
    {
        private readonly IMapper _mapper;

        public OrderDalEf(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<OrderDTO> GetAllOrders()
        {
            using (var entities = new TradingCompanyEntities())
            {
                var orders = entities.Orders.ToList();
                return _mapper.Map<List<OrderDTO>>(orders);
            }
        }

        public OrderDTO GetOrderByID(long orderID)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var order = entities.Orders.SingleOrDefault(o => o.MainOrderID == orderID);
                return _mapper.Map<OrderDTO>(order);
            }
        }

        public List<OrderDTO> GetOrdersByUserId(long customerID)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var my_orders = entities.Orders.ToList();
                var new_ordersList = (my_orders.FindAll(o => o.CustomerID == customerID));
                return _mapper.Map<List<OrderDTO>>(new_ordersList);
            }
        }
        public OrderDTO CreateOrder(OrderDTO order)
        {
            using (var entities = new TradingCompanyEntities())
            {
                Order o = _mapper.Map<Order>(order);
                entities.Orders.Add(o);
                entities.SaveChanges();
                return _mapper.Map<OrderDTO>(o);
            }
        }

        public OrderDTO UpdateOrder(OrderDTO order)
        {
            using (var entities = new TradingCompanyEntities())
            {
                entities.Orders.AddOrUpdate(_mapper.Map<Order>(order));
                var o = entities.Orders.Single(ord => ord.MainOrderID == order.MainOrderID);
                entities.SaveChanges();
                return _mapper.Map<OrderDTO>(o);
            }
        }
        //public void SetOrderStatus(long orderID, short statusID)
        //{
        //    using (var entities = new TradingCompanyEntities())
        //    {
        //        entities.Orders.AddOrUpdate(_mapper.Map<Order>)
        //    }
        //}
    }
}