using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.DatabaseModels
{
    public class VehicleType : BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
