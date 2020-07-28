using AutoMapper;
using BusinessLogic.Models.Vehicles;
using CarStoreDatabaseAccess.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Profiles
{
    public class VehicleProfile : Profile
    {
        public VehicleProfile()
        {
            CreateMap<Vehicle, VehicleDto>()
                .ForMember(x => x.VehicleType, x => x.MapFrom(z => z.VehcileType.Name));
            CreateMap<VehicleDto, Vehicle>();
        }
    }
}
