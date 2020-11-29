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
        public List<ItemDTO> GetAllItems()
        {
            using (var entities = new TradingCompanyEntities())
            {
                var items = entities.Items.ToList();
                return _mapper.Map<List<ItemDTO>>(items);
            }
        }
        public ItemDTO UpdateItem(ItemDTO item)
        {
            using (var entities = new TradingCompanyEntities())
            {
                entities.Items.AddOrUpdate(_mapper.Map<Item>(item));
                var _item = entities.Items.Single(i => i.ItemID == item.ItemID);
                entities.SaveChanges();
                return _mapper.Map<ItemDTO>(_item);
            }
        }
        public ItemDTO CreateItem(ItemDTO item)
        {
            using (var entities = new TradingCompanyEntities())
            {
                Item i = _mapper.Map<Item>(item);
                entities.Items.Add(i);
                entities.SaveChanges();
                return _mapper.Map<ItemDTO>(i);
            }
        }
        public void DeleteItem(long id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var _item = entities.Items.SingleOrDefault(i => i.ItemID == id);
                if (_item == null)
                    return;
                entities.Items.Remove(_item);
                entities.SaveChanges();
            }
        }
    }
}
