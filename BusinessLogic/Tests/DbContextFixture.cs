using AutoMapper;
using BusinessLogic.Profiles;
using CarStoreDatabaseAccess;
using CarStoreDatabaseAccess.DatabaseModels;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Tests
{
    public class DbContextFixture
    {
        public static int DbId = 1;
        public CarStoreContext Context;
        public IMapper Mapper;
        public DbContextFixture()
        {
            Context = new FakeDb();
            var assembly = typeof(RoleProfile).Assembly;
            var profiles = assembly.GetTypes().Where(x => x.IsClass && x.IsSubclassOf(typeof(Profile)));
            var mapper = new MapperConfiguration(x => {
                foreach (var profile in profiles)
                {
                    var parsedProfile = (Profile)Activator.CreateInstance(profile);
                    x.AddProfile(parsedProfile);
                }
            });
            var IMapper = mapper.CreateMapper();
            Mapper = IMapper;
        }
    }

    public class FakeDb : CarStoreContext
    {
        public FakeDb()
        {
            this.AddInitialData();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseInMemoryDatabase("fakeDb_" + new Random().Next(1,100000));
        }
    }

    public static class CarStoreFakeDbContextInitializer
    {
        public static void AddInitialData(this CarStoreContext ctx)
        {
            ctx.Roles.AddRange(new List<Role>()
            {
                new Role
                {
                    Id = 1,
                    Name = "Role 1"
                },
                new Role
                {
                    Id = 2,
                    Name = "Role 2"
                },
                new Role
                {
                    Id = 3,
                    Name = "Role 3"
                }
            });

            ctx.Users.AddRange(new List<User>()
            {
                new User
                {
                    Id = 1,
                    FirstName = "Strong",
                    LastName = "User",
                    Email = "mail",
                    UserAddress = "Address",
                    Password = "Password",
                    IdRole = 1
                },
                new User
                {
                    Id = 2,
                    FirstName = "AAAA",
                    LastName = "User",
                    Email = "mail",
                    UserAddress = "Address",
                    Password = "Password",
                    IdRole = 2
                },
                new User
                {
                    Id = 3,
                    FirstName = "AAAA",
                    LastName = "User",
                    Email = "mail",
                    UserAddress = "Address",
                    Password = "Password",
                    IdRole = 2
                }
            });

            ctx.Features.Add(new Feature
            {
                Id = 1,
                Name = "HorsePower"
            });

            ctx.VehcileTypes.Add(new VehicleType
            {
                Id = 1,
                Name = "Vehicle Type"
            });

            ctx.Vehicles.Add(new Vehicle
            {
                Name = "Vehicle",
                VehicleTypeId = 1
            });

            ctx.Ads.AddRange(new List<Ad>()
            {
                new Ad
                {
                    Id = 1,
                    IdUser = 1,
                    Discount = 10,
                    VehicleId = 1,
                    Price = 1000,
                    AdFeatureValues = new List<AdFeatureValue>(){
                        new AdFeatureValue
                        {
                            IdAd = 1,
                            IdFeature = 1,
                            Value = 100
                        }
                    }
                },
                new Ad
                {
                    Id = 2,
                    IdUser = 1,
                    Discount = 10,
                    VehicleId = 1,
                    Price = 1000,
                    AdFeatureValues = new List<AdFeatureValue>(){
                        new AdFeatureValue
                        {
                            IdAd = 2,
                            IdFeature = 1,
                            Value = 70
                        }
                    }
                }
            });

            ctx.SaveChanges();
        }
    }
}
