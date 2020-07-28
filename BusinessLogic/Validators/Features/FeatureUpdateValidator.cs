using BusinessLogic.Models.Features;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.Features
{
    [Action(ActionType.Update)]
    public class FeatureUpdateValidator : AbstractValidator<FeatureDto>
    {
        public FeatureUpdateValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Role Name can't be empty.")
                .Must((x,y) => !_ctx.VehcileTypes.Any(z => z.Name == y && z.Id != x.Id)).WithMessage("Role name must be unique.");
        }
    }
}
