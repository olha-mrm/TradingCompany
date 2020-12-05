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

        public DeliveryStatuDTO GetDelStatusById(short id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var delStatus = entities.DeliveryStatus.SingleOrDefault(ds => ds.DeliveryStatusID == id);
                return _mapper.Map<DeliveryStatuDTO>(delStatus);
            }
        }

        public DeliveryStatuDTO CreateDeliveryStatus(DeliveryStatuDTO delStatus)
        {
            using (var entities = new TradingCompanyEntities())
            {
                DeliveryStatu ds = _mapper.Map<DeliveryStatu>(delStatus);
                entities.DeliveryStatus.Add(ds);
                entities.SaveChanges();
                return _mapper.Map<DeliveryStatuDTO>(ds);
            }
        }

        public void DeleteDelStatus(short id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var ds = entities.DeliveryStatus.SingleOrDefault(_ds => _ds.DeliveryStatusID == id);
                if (ds == null) 
                    return;
                entities.DeliveryStatus.Remove(ds);
                entities.SaveChanges();
            }
        }

        public DeliveryStatuDTO UpdateDeliveryStatus(DeliveryStatuDTO delStatus)
        {
            using (var entities = new TradingCompanyEntities())
            {
                entities.DeliveryStatus.AddOrUpdate(_mapper.Map<DeliveryStatu>(delStatus));
                var dstatus = entities.DeliveryStatus.Single(ds => ds.DeliveryStatusID == delStatus.DeliveryStatusID);
                entities.SaveChanges();
                return _mapper.Map<DeliveryStatuDTO>(dstatus);
            }
        }
    }
}
