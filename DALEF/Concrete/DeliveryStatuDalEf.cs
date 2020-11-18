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
    public class DeliveryStatuDalEf : IDeliveryStatuDal
    {
        private readonly IMapper _mapper;
        public DeliveryStatuDalEf(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<DeliveryStatuDTO> GetAllStatuses()
        {
            using (var entities = new TradingCompanyEntities())
            {
                var statuses = entities.DeliveryStatus.ToList();
                return _mapper.Map<List<DeliveryStatuDTO>>(statuses);
            }
        }
        public string GetStatusNameById(short id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var status = entities.DeliveryStatus.SingleOrDefault(s => s.DeliveryStatusID == id);
                return _mapper.Map<string>(status.Status);
            }
        }
    }
}
