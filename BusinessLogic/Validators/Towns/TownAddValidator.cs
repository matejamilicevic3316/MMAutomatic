using BusinessLogic.Models.Towns;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.Towns
{
    [Action(ActionType.Add)]
    public class TownAddValidator : AbstractValidator<TownDto>
    {
        public TownAddValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Town is required field.")
                .Must(x => !_ctx.Towns.Any(z => z.Name == x))
                .WithMessage("{PropertyValue} is already in use");
        }
    }
}
