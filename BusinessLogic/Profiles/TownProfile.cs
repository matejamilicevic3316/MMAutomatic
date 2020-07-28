using AutoMapper;
using BusinessLogic.Models.Towns;
using CarStoreDatabaseAccess.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Profiles
{
    public class TownProfile : Profile
    {
        public TownProfile()
        {
            CreateMap<Town, TownDto>();
            CreateMap<TownDto, Town>();
        }
    }
}
