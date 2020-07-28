using BusinessLogic.Models.Vehicles;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.Vehicles
{
    [Action(ActionType.Add)]
    public class AddVehicleValidator : AbstractValidator<VehicleDto>
    {
        public AddVehicleValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("{PropertyName} is required field.")
                .Must(x => !_ctx.Vehicles.Any(z => z.Name == x))
                .WithMessage("{PropertyName} must be unique.");
            RuleFor(x => x.VehicleTypeId)
                .NotEmpty()
                .WithMessage("{PropertyName} is required field.")
                .Must(x => _ctx.VehcileTypes.Find(x) != null)
                .WithMessage("{PropertyName} doesnt exist in system.");
        }
    }
}
