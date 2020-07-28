using System.Collections;
using System.Collections.Generic;

namespace CarStoreDatabaseAccess.DatabaseModels
{
    public class AdFeatureValue
    {
        public int IdAd { get; set; }
        public int IdFeature { get; set; }
        public decimal Value { get; set; }
        public virtual Ad Ad { get; set; }
        public virtual Feature Feature { get; set; }
    }
}