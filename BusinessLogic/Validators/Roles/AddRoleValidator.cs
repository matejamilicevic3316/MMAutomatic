using BusinessLogic.Models;
using CarStoreDatabaseAccess;
using CrudAutomaticBusinessLogic;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators
{
    [Action(ActionType.Add)]
    public class AddRoleValidator : AbstractValidator<RoleDto>
    {
        public AddRoleValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Role Name can't be empty.")
                .Must(y => !_ctx.Roles.Any(x => x.Name == y)).WithMessage("Role name must be unique.");
        }
    }
}
