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
    public class OrdersRefDalEf : IOrdersRefDal
    {
        private readonly IMapper _mapper;

        public OrdersRefDalEf(IMapper mapper)
        {
            _mapper = mapper;
        }

        //?

        public List<OrdersRefDTO> GetItemsInOrder(long orderID) //returns all items in order by orderID
        {
            using (var entities = new TradingCompanyEntities()) 
            {
                var ordersRefs = entities.OrdersRefs.ToList();
                var new_ordersRefs = ordersRefs.FindAll(o => o.refOrderID == orderID);
                return _mapper.Map<List<OrdersRefDTO>>(new_ordersRefs);
            }    
        }

        public List<OrdersRefDTO> GetOrdersByItem(long itemID)
        {
            using (var entities = new TradingCompanyEntities()) 
            {
                var ordersRefs = entities.OrdersRefs.ToList();
                var new_ordersRefs = (ordersRefs.FindAll(o => o.refItemID == itemID));
                return _mapper.Map<List<OrdersRefDTO>>(new_ordersRefs);
            }
        }
        public OrdersRefDTO CreateOrderRef(OrdersRefDTO orderRef)
        {
            using (var entities = new TradingCompanyEntities())
            {
                OrdersRef o = _mapper.Map<OrdersRef>(orderRef);
                entities.OrdersRefs.Add(o);
                entities.SaveChanges();
                return _mapper.Map<OrdersRefDTO>(o);
            }
        }
        public void DeleteOrderRef(long orderID, long itemID)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var o = entities.OrdersRefs.SingleOrDefault(oo => (oo.refOrderID == orderID & oo.refItemID == itemID));
                if (o == null)
                {
                    return;
                }
                entities.OrdersRefs.Remove(o);
                entities.SaveChanges();
            }
        }
        public OrdersRefDTO UpdateOrderRef(OrdersRefDTO orderRef)
        {
            using (var entities = new TradingCompanyEntities())
            {
                entities.OrdersRefs.AddOrUpdate(_mapper.Map<OrdersRef>(orderRef));
                var _orderRef = entities.OrdersRefs.Single(o => (o.refOrderID == orderRef.refOrderID & o.refItemID == orderRef.refItemID));
                entities.SaveChanges();
                return _mapper.Map<OrdersRefDTO>(_orderRef);
            }
        }
    }
}