using AutoMapper;
using CarStoreDatabaseAccess;
using CarStoreDatabaseAccess.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CrudAutomaticBusinessLogic.QuerySearch;

namespace CrudAutomaticBusinessLogic.CrudExecutors
{
    public class SearchExecutor<TEntity,TDto> : CrudExecutor
        where TDto : IdentifyableDto
        where TEntity : BaseModel
    {
        public SearchExecutor(DbContext ctx, IMapper mapper) : base(ctx, mapper)
        {
        }

        public object Execute(CrudSearch search)
        {
            var dbSet = _ctx.Set<TEntity>();

            var result = dbSet.AsQueryable();

            var queryBuilder = new QueryBuilder<TEntity>(result);

            queryBuilder.FilterQuery(search);

            var resultCount = queryBuilder._query.Count();

            if (search.Paginate)
            {
                queryBuilder.Paginate(search);
            }

            var mappedProperties = _mapper.Map<ICollection<TDto>>(queryBuilder._query.ToList());

            if (search.Paginate)
            {
                return new PagedResponse<TDto>
                {
                    Dtos = mappedProperties,
                    Page = search.Page,
                    PerPage = search.PerPage,
                    TotalPages = (int)Math.Ceiling((decimal)resultCount/search.PerPage)
                };
            }

            return mappedProperties;
        }
    }

    public class PagedResponse<TDto>
    {
        public int PerPage { get; set; }
        public int Page { get; set; }
        public IEnumerable<TDto> Dtos { get; set; }
        public int TotalPages { get; set; }
    }
}
