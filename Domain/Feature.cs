using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.DatabaseModels
{
    public class Feature : BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<AdFeatureValue> AdFeatureValues { get; set; }
    }
}
