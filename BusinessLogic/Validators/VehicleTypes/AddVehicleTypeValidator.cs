using BusinessLogic.Models.VehicleTypes;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.VehicleTypes
{
    [Action(ActionType.Add)]
    public class AddVehicleTypeValidator : AbstractValidator<VehicleTypeDto>
    {
        public AddVehicleTypeValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Role Name can't be empty.")
                .Must(y => !_ctx.VehcileTypes.Any(x => x.Name == y)).WithMessage("Role name must be unique.");
        }
    }
}
