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
    [Action(ActionType.Update)]
    public class UpdateRoleValidator : AbstractValidator<RoleDto>
    {
        public UpdateRoleValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Role Name can't be empty.")
                .Must((z,y) => !_ctx.Roles.Any(x => x.Name == y && x.Id != z.Id)).WithMessage("Role name must be unique.");
        }
    }
}
