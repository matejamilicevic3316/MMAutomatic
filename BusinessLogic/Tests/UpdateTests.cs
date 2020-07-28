using BusinessLogic.Models;
using BusinessLogic.Models.Ads;
using BusinessLogic.Validators;
using BusinessLogic.Validators.Ads;
using CarStoreDatabaseAccess.DatabaseModels;
using CrudAutomaticBusinessLogic;
using CrudAutomaticBusinessLogic.CrudExecutors;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BusinessLogic.Tests
{
    public class UpdateTests : IClassFixture<DbContextFixture>
    {
        private DbContextFixture DbContextFixture;
        public UpdateTests(DbContextFixture dbContextFixture)
        {
            DbContextFixture = dbContextFixture;
        }

        [Fact]
        public void UpdateRoleWorks() 
        { 
            var role = DbContextFixture.Context.Roles.Find(1);

            role.Name.Should().Be("Role 1");

            var updateRoleDto = new RoleDto
            {
                Id = 1,
                Name = "Updated Role"
            };

            var updateExecutor = new UpdateExecutor<Role, RoleDto>(DbContextFixture.Context, DbContextFixture.Mapper, new UpdateRoleValidator(DbContextFixture.Context));

            updateExecutor.Execute(updateRoleDto);

            role.Name.Should().Be("Updated Role");
        }

        [Fact]
        public void UpdateWithAditionalMappingWorks()
        {
            var updateExecutor = new UpdateExecutor<Ad, AdDto>(DbContextFixture.Context, DbContextFixture.Mapper, new UpdateAdValidator(DbContextFixture.Context));

            var ad = DbContextFixture.Context.Ads.Find(1);

            var updateRoleDto = new AdDto
            {
                Id = 1,
                Discount = 15,
                YearProduced = 2005,
                Price = 1100,
                IdUser = 1,
                VehicleId = 1,
                FeatureValues = new List<FeatureValue>()
                {
                }
            };

            updateExecutor.Execute(updateRoleDto);

            ad = DbContextFixture.Context.Ads.Find(1);

            ad.AdFeatureValues.Count().Should().Be(0);

            ad.Price.Should().Be(1100);
            ad.Discount.Should().Be(15);
            ad.AdFeatureValues.Count().Should().Be(0);

            
            updateRoleDto = new AdDto
            {
                Id = 1,
                Discount = 0,
                YearProduced = 2005,
                Price = 900,
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

            updateExecutor.Execute(updateRoleDto);

            ad = DbContextFixture.Context.Ads.Find(1);

            ad.Price.Should().Be(900);
            ad.Discount.Should().Be(0);
            ad.AdFeatureValues.FirstOrDefault().Value.Should().Be(110);
        }
    }
}
