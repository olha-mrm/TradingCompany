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
    public class ItemDalEf: IItemDal
    {
        private readonly IMapper _mapper;

        public ItemDalEf(IMapper mapper)
        {
            _mapper = mapper;
        }

        public string GetNameByID(long id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var item = entities.Items.SingleOrDefault(i => i.ItemID == id);
                return _mapper.Map<string>(item.Title);
            }
        }

        public ItemDTO GetItemById(long id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var item = entities.Items.SingleOrDefault(i => i.ItemID == id);
                return _mapper.Map<ItemDTO>(item);
            }
        }
    }
}
