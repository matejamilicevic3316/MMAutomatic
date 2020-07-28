using BusinessLogic.Models.Users;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.Users
{
    [Action(ActionType.Add)]
    public class AddUserValidator : AbstractValidator<UserDto>
    {
        public AddUserValidator(CarStoreContext _ctx)
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("{PropertyName} is required.")
                .Must(x => !_ctx.Users.Any(z => z.Username == x)).WithMessage("{PropertyName} is already in use.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("{PropertyName} is required.")
                .Must(x => !_ctx.Users.Any(z => z.Email == x)).WithMessage("{PropertyName} is already in use.");
            RuleFor(x => x.IdRole).NotEmpty().WithMessage("{PropertyName} is required.")
                .Must(x => _ctx.Roles.Any(z => z.Id == x)).WithMessage("{PropertyName} doesnt exist in system.");
            RuleFor(x => x.IdTown)
                .Must(x => _ctx.Towns.Any(z => z.Id == x))
                .When(x => x.IdTown != null)
                .WithMessage("{PropertyName} doesnt exist in system.");
        }
    }
}
