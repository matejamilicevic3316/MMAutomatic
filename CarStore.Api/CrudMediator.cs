using AutoMapper;
using BusinessLogic.Models;
using CarStoreDatabaseAccess;
using Microsoft.Extensions.DependencyInjection;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic;
using CrudAutomaticBusinessLogic.QuerySearch;
using CrudAutomaticBusinessLogic.CrudExecutors;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using BusinessLogic;

namespace CarStore.Api
{
    public class CrudMediator
    {
        IMapper _mapper;
        CarStoreContext _ctx;
        IServiceProvider _serviceProvider;

        public CrudMediator(IMapper mapper, CarStoreContext ctx, IServiceProvider serviceProvider)
        {
            _mapper = mapper;
            _ctx = ctx;
            _serviceProvider = serviceProvider;
        }
        public object Search<TEntity,TDto>(CrudSearch search)
            where TEntity : BaseModel
            where TDto : IdentifyableDto
        {
            var executor = new SearchExecutor<TEntity,TDto>(_ctx, _mapper);
            var result = executor.Execute(search);
            return result;
        }

        public TDto Find<TEntity,TDto>(int id)
            where TEntity : BaseModel
            where TDto : IdentifyableDto
        {
            var executor = new FindExecutor<TEntity, TDto>(_ctx, _mapper);
            var result = executor.Execute(id);
            return result;
        }

        public void Add<TEntity, TDto>(TDto dto)
            where TEntity : BaseModel
            where TDto : IdentifyableDto
        {
            var validatorAdd = GetValidator<TDto>(ActionType.Add, _serviceProvider);
            var executor = new AddExecutor<TEntity, TDto>(_ctx, _mapper, validatorAdd);
            executor.Execute(dto);
        }

        public void Update<TEntity, TDto>(TDto dto)
            where TEntity : BaseModel
            where TDto : IdentifyableDto
        {
            var validatorUpdate = GetValidator<TDto>(ActionType.Update, _serviceProvider);
            var executor = new UpdateExecutor<TEntity, TDto>(_ctx, _mapper, validatorUpdate);
            executor.Execute(dto);
        }

        public void Delete<TEntity>(int id)
            where TEntity : BaseModel
        {
            var executor = new DeleteExecutor<TEntity>(_ctx, _mapper);
            executor.Execute(id);
        }

        private IValidator<TDto> GetValidator<TDto>(ActionType actionType, IServiceProvider serviceProvider)
        {
            var validators = serviceProvider.GetServices<IValidator<TDto>>();

            IValidator<TDto> iValidator = null;

            foreach (var validator in validators)
            {
                var attribute = (ActionAttribute)validator.GetType().GetCustomAttributes(typeof(ActionAttribute), true).FirstOrDefault();
                if (attribute._action == actionType)
                {
                    iValidator = validator;
                    break;
                }
            }

            return iValidator;
        }
    }
}
