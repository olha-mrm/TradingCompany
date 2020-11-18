using AutoMapper;
using DAL.Interfaces;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEF.Concrete
{
    public class OrderDalEf //: IOrderDal
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

        //public void SetOrderStatus(long orderID, short statusID)
        //{
        //    using (var entities = new TradingCompanyEntities())
        //    {
        //        entities.Orders.AddOrUpdate(_mapper.Map<Order>)
        //    }
        //}
    }
}