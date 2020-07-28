using BusinessLogic.Models.Ads;
using BusinessLogic.Models.Users;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.Users
{
    [Action(ActionType.Update)]
    public class UpdateUserValidator : AbstractValidator<UserDto>
    {
        public UpdateUserValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("{PropertyName} is required.")
                .Must((y, x) => !_ctx.Users.Any(z => z.Username == x && z.Id != y.Id)).WithMessage("{PropertyName} is already in use.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("{PropertyName} is required.")
                .Must((y,x) => !_ctx.Users.Any(z => z.Email == x && z.Id != y.Id)).WithMessage("{PropertyName} is already in use.");
            RuleFor(x => x.IdRole).NotEmpty().WithMessage("{PropertyName} is required.")
                .Must(x => _ctx.Roles.Any(z => z.Id == x)).WithMessage("{PropertyName} doesnt exist in system.");
            RuleFor(x => x.IdTown)
                .Must(x => _ctx.Towns.Any(z => z.Id == x))
                .When(x => x.IdTown != null)
                .WithMessage("{PropertyName} doesnt exist in system.");
        }
    }
}
