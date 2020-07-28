using AutoMapper;
using BusinessLogic.Models.Features;
using CarStoreDatabaseAccess.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Profiles
{
    public class FeaturesProfile : Profile
    {
        public FeaturesProfile()
        {
            CreateMap<Feature, FeatureDto>();
            CreateMap<FeatureDto, Feature>();
        }
    }
}
