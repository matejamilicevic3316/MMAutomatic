using CrudAutomaticBusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BusinessLogic.Models.Vehicles
{
    public class VehicleDto : IdentifyableDto
    {
        public int VehicleTypeId { get; set; }
        public string VehicleType { get; set; }
        public string Name { get; set; }
    }
}
