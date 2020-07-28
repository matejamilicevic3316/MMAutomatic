using BusinessLogic.Models.VehicleTypes;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.VehicleTypes
{
    [Action(ActionType.Update)]
    public class UpdateVehicleTypeValidator : AbstractValidator<VehicleTypeDto>
    {
        public UpdateVehicleTypeValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("VehicleType Name can't be empty.")
                .Must((z,y) => !_ctx.Roles.Any(x => x.Name == y && x.Id != z.Id)).WithMessage("VehicleType name must be unique.");
        }
    }
}
