using CrudAutomaticBusinessLogic.QuerySearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.SearchObjects
{
    public class VehcileTypeSearch : CrudSearch
    {
        [SearchField(ComparationType.Contains)]
        public string Name { get; set; }
    }
}
