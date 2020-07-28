using CrudAutomaticBusinessLogic.QuerySearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.SearchObjects
{
    public class FeatureSearch : CrudSearch
    {
        [SearchField(ComparationType.Contains,"Name")]
        public string Keyword { get; set; }
    }
}
