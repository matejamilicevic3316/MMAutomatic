using AutoMapper;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudAutomaticBusinessLogic.CrudExecutors
{
    public class FindExecutor<TEntity, TDto> : CrudExecutor
        where TDto : IdentifyableDto
        where TEntity : BaseModel
    {
        public FindExecutor(DbContext ctx, IMapper mapper) : base(ctx, mapper)
        {
        }

        public TDto Execute(int id)
        {
            var dbSet = _ctx.Set<TEntity>();
            var entity = dbSet.Find(id);
            if (entity == null)
            {
                throw new NotFoundException();
            }
            var dto = _mapper.Map<TDto>(entity);
            _ctx.SaveChanges();
            return dto;
        }
    }
}
