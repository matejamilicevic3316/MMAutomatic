using System;
using System.Collections.Generic;
using System.Text;

namespace CrudAutomaticBusinessLogic.QuerySearch
{
    public abstract class CrudSearch
    {
        public int PerPage { get; set; } = 3;
        public int Page { get; set; } = 1;
        public bool Paginate { get; set; } = false;
        public string SortProperty { get; set; } = "Id";
        public QuerySort QuerySort { get; set; } = QuerySort.ASC;
    }

    public enum QuerySort
    {
        ASC,
        DESC
    }
}
