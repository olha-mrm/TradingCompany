﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL.Interfaces
{
    public interface IItemDal
    {
        string GetNameByID(long id);
        ItemDTO GetItemById(long id);
    }
}
