using AutoMapper;
using BusinessLogic.Models.Ads;
using BusinessLogic.Models.Users;
using CarStoreDatabaseAccess.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, ReadUserDto>()
                .ForMember(x => x.Ads, x => x.MapFrom(y => y.Ads.Select(z => new MicroAdDto
                {
                    User = z.User.Username,
                    VehicleName = z.Vehicle.Name,
                    Price = z.Discount == null ? z.Price : z.Price - z.Price * (decimal)z.Discount/100
                })))
                .ForMember(x => x.TownName, x => x.MapFrom(y => y.Town.Name))
                .ForMember(x => x.RoleName, x => x.MapFrom(y => y.Role.Name));
            CreateMap<UserDto, User>();
        }
    }
}
