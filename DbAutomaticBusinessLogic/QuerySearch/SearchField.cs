using System;
using System.Collections.Generic;
using System.Text;

namespace CrudAutomaticBusinessLogic.QuerySearch
{
    public class SearchFieldAttribute : Attribute
    {
        public string[] _fieldsToCompareWith;
        public ComparationType _comparation;
        public SearchFieldAttribute(ComparationType comaparationType, params string[] fields)
        {
            _fieldsToCompareWith = fields;
            _comparation = comaparationType;
        }
    }
    public enum ComparationType
    {
        GreaterThan,
        Equal,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual,
        Contains,
        StartsWith
    }
}
