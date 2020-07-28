using CrudAutomaticBusinessLogic.QuerySearch;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.SearchObjects
{
    public class UserSearch : CrudSearch
    {
        [SearchField(ComparationType.Contains, "Username", "Email")]
        public string Keyword { get; set; }
        
        [SearchField(ComparationType.StartsWith, "Town.Name")]
        public string TownName { get; set; }
    }
}
