using AutoMapper;
using BusinessLogic.Models.VehicleTypes;
using CarStoreDatabaseAccess.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Profiles
{
    public class VehicleTypeProfile : Profile
    {
        public VehicleTypeProfile()
        {
            CreateMap<VehicleTypeDto, VehicleType>();
            CreateMap<VehicleType, VehicleTypeDto>();
        }
    }
}
