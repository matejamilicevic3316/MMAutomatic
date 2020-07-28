using CrudAutomaticBusinessLogic.QuerySearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.SearchObjects
{
    public class AdsSearch : CrudSearch
    {
        [SearchField(ComparationType.GreaterThan, "AdFeatureValues.Feature.Name.HorsePower")]
        public decimal? MinHorsePower { get; set; } = null;
        [SearchField(ComparationType.LessThan, "AdFeatureValues.Feature.Name.HorsePower")]
        public decimal? MaxHorsePower { get; set; } = null;
        [SearchField(ComparationType.Contains, "User.Username","User.Email")]
        public string AdPublisher { get; set; }
        [SearchField(ComparationType.GreaterThan, "AdFeatureValues.Feature.Name.EngineVolume")]
        public decimal? MinEngineVolume { get; set; }
        [SearchField(ComparationType.LessThan, "AdFeatureValues.Feature.Name.EngineVolume")]
        public decimal? MaxEngineVolume { get; set; }
        [SearchField(ComparationType.Equal, "User.Town.Id")]
        public int? TownId { get; set; }
        [SearchField(ComparationType.Equal, "Vehicle.VehicleTypeId")]
        public int? VehicleTypeId { get; set; }
        [SearchField(ComparationType.StartsWith, "Vehicle.Name")]
        public string VehicleName { get; set; }
        [SearchField(ComparationType.GreaterThanOrEqual, "YearProduced")]
        public int? YearProducedFrom { get; set; }
        [SearchField(ComparationType.LessThanOrEqual, "YearProduced")]
        public int? YearProducedTo { get; set; }
    }
}
