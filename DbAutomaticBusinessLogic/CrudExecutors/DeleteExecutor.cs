using AutoMapper;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudAutomaticBusinessLogic.CrudExecutors
{
    public class DeleteExecutor<TEntity> : CrudExecutor
        where TEntity : BaseModel
    {
        public DeleteExecutor(DbContext ctx, IMapper mapper) : base(ctx, mapper)
        {
        }

        public void Execute(int id)
        {
            var dbSet = _ctx.Set<TEntity>();
            var entity = dbSet.Find(id);
            if(entity == null)
            {
                throw new NotFoundException();
            }
            dbSet.Remove(entity);
            _ctx.SaveChanges();
        }
    }
}
