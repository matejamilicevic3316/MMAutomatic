using CrudAutomaticBusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BusinessLogic.Models.Ads
{
    public class AdDto : IdentifyableDto
    {
        public int VehicleId { get; set; }
        public int IdUser { get; set; }
        public int YearProduced { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public IEnumerable<FeatureValue> FeatureValues { get; set; }
    }

    public class ReadAdDto : IdentifyableDto
    {
        public string VehicleName { get; set; }
        public int YearProduced { get; set; }
        public string User { get; set; }
        public decimal Price { get; set; }
        public IEnumerable<FeatureValue> FeatureValues { get; set; }
    }

    public class FeatureValue
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
