using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.DatabaseModels
{
    public class Ad : BaseModel
    {
        public int VehicleId { get; set; }
        public int IdUser { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int YearProduced { get; set; }
        public virtual User User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ICollection<AdFeatureValue> AdFeatureValues { get; set; }
    }
}
