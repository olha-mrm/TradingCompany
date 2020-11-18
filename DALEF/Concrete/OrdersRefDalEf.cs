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
    public class OrdersRefDalEf : IOrdersRefDal
    {
        private readonly IMapper _mapper;

        public OrdersRefDalEf(IMapper mapper)
        {
            _mapper = mapper;
        }

        //?

        public List<OrdersRefDTO> GetItemsInOrder(long orderID)
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
    }
}