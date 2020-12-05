using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDeliveryStatuDal
    {
        string GetStatusNameById(short id); 
        List<DeliveryStatuDTO> GetAllStatuses(); 
        DeliveryStatuDTO GetDelStatusById(short id); 
        DeliveryStatuDTO CreateDeliveryStatus(DeliveryStatuDTO delStatus);
        DeliveryStatuDTO UpdateDeliveryStatus(DeliveryStatuDTO delStatus);
        void DeleteDelStatus(short id);
    }
}
