using AutoMapper;
using CarStoreDatabaseAccess;
using CarStoreDatabaseAccess.DatabaseModels;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudAutomaticBusinessLogic
{
    public abstract class CrudExecutor
    {
        public readonly IMapper _mapper;
        public readonly DbContext _ctx;
        public CrudExecutor(DbContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }
    }
}
