using AutoMapper;
using CarStoreDatabaseAccess.DatabaseModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using System.Linq;
using CrudAutomaticBusinessLogic.Exceptions;

namespace CrudAutomaticBusinessLogic.CrudExecutors
{
    public class AddExecutor<TEntity,TDto> : CrudExecutor
        where TDto : IdentifyableDto
        where TEntity : BaseModel
    {
        private IValidator<TDto> _validator;
        public AddExecutor(DbContext ctx, IMapper mapper, IValidator<TDto> validator) : base(ctx, mapper)
        {
            _validator = validator;
        }

        public void Execute(TDto dto)
        {
            var dbSet = _ctx.Set<TEntity>();
            var validationResponse = _validator.Validate(dto);
            if (validationResponse.Errors.Any())
            {
                throw new CrudValidationException(validationResponse.Errors);
            };
            var entity = _mapper.Map<TEntity>(dto);
            dbSet.Add(entity);
            _ctx.SaveChanges();
        }
    }
}
