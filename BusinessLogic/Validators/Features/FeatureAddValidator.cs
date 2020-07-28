using BusinessLogic.Models.Features;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.Features
{
    [Action(ActionType.Add)]
    public class FeatureAddValidator : AbstractValidator<FeatureDto>
    {
        public FeatureAddValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Role Name can't be empty.")
                .Must(y => !_ctx.VehcileTypes.Any(x => x.Name == y)).WithMessage("Role name must be unique.");
        }
    }
}
