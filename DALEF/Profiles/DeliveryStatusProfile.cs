﻿using AutoMapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEF.Profiles
{
    public class DeliveryStatusProfile : Profile
    {
        public DeliveryStatusProfile()
        {
            CreateMap<DeliveryStatu, DeliveryStatuDTO>().ReverseMap();
        }
    }
}
