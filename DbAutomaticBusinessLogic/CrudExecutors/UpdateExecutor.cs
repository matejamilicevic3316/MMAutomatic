using AutoMapper;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.Exceptions;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrudAutomaticBusinessLogic.CrudExecutors
{
    public class UpdateExecutor<TEntity,TDto> : CrudExecutor
        where TDto : IdentifyableDto
        where TEntity : BaseModel
    {
        private IValidator<TDto> _validator;
        public UpdateExecutor(DbContext ctx, IMapper mapper, IValidator<TDto> validator) : base(ctx, mapper)
        {
            _validator = validator;
        }

        public void Execute(TDto dto)
        {
            var dbSet = _ctx.Set<TEntity>();
            var entity = dbSet.Find(dto.Id);
            if (entity == null)
            {
                throw new NotFoundException();
            }
            var validationResponse = _validator.Validate(dto);
            
            if (validationResponse.Errors.Any())
            {
                throw new CrudValidationException(validationResponse.Errors);
            };

            _mapper.Map(dto, entity);

            dbSet.Update(entity);

            _ctx.SaveChanges();
        }
    }
}
