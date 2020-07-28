using BusinessLogic.Models.Ads;
using CarStoreDatabaseAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Validators.Ads
{
    [Action(ActionType.Update)]
    public class UpdateAdValidator : AbstractValidator<AdDto>
    {
        private readonly CarStoreContext _ctx;
        public UpdateAdValidator(CarStoreContext ctx)
        {
            _ctx = ctx;

            RuleFor(x => x.VehicleId)
                .NotEmpty()
                .WithMessage("VehicleId must have value.")
                .Must(x => _ctx.Vehicles.Find(x) != null)
                .WithMessage("VehicleId doesnt exist in system.");
            RuleFor(x => x.IdUser)
                .NotEmpty()
                .WithMessage("User id must have value")
                .Must(x => _ctx.Users.Find(x) != null)
                .WithMessage("UserId doesnt exist in system.");
            RuleFor(x => x.Discount)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(100)
                .When(x => x.Discount != null)
                .WithMessage("{PropertyName} must be between 0 and 100.");
            RuleFor(x => x.Price)
                .GreaterThan(0)
                .WithMessage("{PropertyName} must be greater than 0.");
            RuleFor(x => x.YearProduced)
                .Must(x => x <= DateTime.Now.Year)
                .WithMessage("{PropertyName} must be less or equal to present year.")
                .Must(x => x > 1910)
                .WithMessage("{PropertyName} must be greater than 1910.");
            RuleForEach(x => x.FeatureValues)
                .Must(x => ValidateFeatures(x))
                .WithMessage("Feature values error.");
        }


        private bool ValidateFeatures(FeatureValue ad)
        {
            var featureName = _ctx.Features.FirstOrDefault(x => x.Id == ad.FeatureId).Name;
            var isValid = false;
            switch (featureName.ToLower())
            {
                case "horsepower":
                    isValid = ad.Value > 50 && ad.Value < 800;
                    break;
                case "enginevolume":
                    isValid = ad.Value > 800 && ad.Value < 8000;
                    break;
                case "airbag":
                    isValid = ad.Value == 1 || ad.Value == 0;
                    break;
            };

            return isValid;
        }
    }
}
