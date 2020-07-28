using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.DatabaseModels
{
    public class Vehicle : BaseModel
    {
        public int VehicleTypeId { get; set; }
        public string Name { get; set; }
        public virtual VehicleType VehcileType { get; set; }
        public virtual ICollection<Ad> Ads { get; set; }
    }
}
