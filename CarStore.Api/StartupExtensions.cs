using AutoMapper;
using BusinessLogic.Profiles;
using BusinessLogic.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Api
{
    public static class StartupExtensions
    {
        public static void SetupMapper(this IServiceCollection services)
        {
            var assembly = typeof(RoleProfile).Assembly;
            var profiles = assembly.GetTypes().Where(x => x.IsClass && x.IsSubclassOf(typeof(Profile)));
            var mapper = new MapperConfiguration(x => { 
                foreach(var profile in profiles)
                {
                    var parsedProfile = (Profile)Activator.CreateInstance(profile);
                    x.AddProfile(parsedProfile);
                }
            });
            var IMapper = mapper.CreateMapper();
            services.AddTransient(x => IMapper);
        }

        public static void AddValidators(this IServiceCollection services)
        {
            var assembly = typeof(AddRoleValidator).Assembly;
            var types = assembly.DefinedTypes.Where(x => x.GetInterfaces()
                                        .Any(x => x.IsGenericType && x.GetGenericTypeDefinition() == typeof(IValidator<>))).ToList();
            foreach(var type in types)
            {
                foreach(var validator in type.ImplementedInterfaces)
                {
                    services.AddTransient(validator, type);
                }
            }
        }
    }
}
