using AutoMapper;
using BusinessLogic.Models.Ads;
using CarStoreDatabaseAccess.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Profiles
{
    public class AdsProfile : Profile
    {
        public AdsProfile()
        {
            CreateMap<Ad, ReadAdDto>()
                .ForMember(x => x.VehicleName, x => x.MapFrom(y => y.Vehicle.Name))
                .ForMember(x => x.User, x => x.MapFrom(y => y.User.Username))
                .ForMember(x => x.Price, x => x.MapFrom(y => y.Discount == null ? y.Price : y.Price - y.Price * (decimal)y.Discount/100))
                .ForMember(x => x.FeatureValues, x => x.MapFrom(y => y.AdFeatureValues.Select(z => new FeatureValue
                {
                    Name = z.Feature.Name,
                    Value = z.Value
                })));
            CreateMap<AdDto, Ad>()
                .ForMember(x => x.AdFeatureValues, x => x.MapFrom(y => y.FeatureValues.Select(z => new AdFeatureValue
                {
                    IdFeature = z.FeatureId,
                    Value = z.Value
                })));
        }
    }
}
