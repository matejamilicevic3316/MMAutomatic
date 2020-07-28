using BusinessLogic.Models.Towns;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.Towns
{
    [Action(ActionType.Update)]
    public class TownUpdateValidator : AbstractValidator<TownDto>
    {
        public TownUpdateValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Town is required field.")
                .Must((y,x) => !_ctx.Towns.Any(z => z.Name == x && z.Id != y.Id))
                .WithMessage("{PropertyValue} is already in use");
        }
    }
}
