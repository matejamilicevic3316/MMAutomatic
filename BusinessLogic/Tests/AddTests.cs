using BusinessLogic.Models;
using BusinessLogic.Models.Ads;
using BusinessLogic.Validators;
using BusinessLogic.Validators.Ads;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic.CrudExecutors;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BusinessLogic.Tests
{
    public class AddTests : IClassFixture<DbContextFixture>
    {
        private readonly DbContextFixture DbContextFixture;
        public AddTests(DbContextFixture dbContextFixture)
        {
            DbContextFixture = dbContextFixture;
        }
        [Fact]
        public void AddRoleWorksProperly()
        {
            var addRoleDto = new RoleDto
            {
                Name = "Added Role"
            };

            var updateExecutor = new AddExecutor<Role, RoleDto>(DbContextFixture.Context, DbContextFixture.Mapper, new AddRoleValidator(DbContextFixture.Context));

            updateExecutor.Execute(addRoleDto);

            var role = DbContextFixture.Context.Roles.Last();

            role.Name.Should().Be("Added Role");
        }

        [Fact]
        public void UpdateWithAditionalMappingWorks()
        {
            var addExecutor = new AddExecutor<Ad, AdDto>(DbContextFixture.Context, DbContextFixture.Mapper, new AddAdValidator(DbContextFixture.Context));

            var adDto = new AdDto
            {
                Discount = 0,
                Price = 900,
                YearProduced = 2005,
                IdUser = 1,
                VehicleId = 1,
                FeatureValues = new List<FeatureValue>()
                {
                    new FeatureValue
                    {
                        FeatureId = 1,
                        Value = 110
                    }
                }
            };

            addExecutor.Execute(adDto);

            var ad = DbContextFixture.Context.Ads.LastOrDefault();

            ad.Price.Should().Be(900);
            ad.Discount.Should().Be(0);
            ad.AdFeatureValues.FirstOrDefault().Value.Should().Be(110);
        }
    }
}
