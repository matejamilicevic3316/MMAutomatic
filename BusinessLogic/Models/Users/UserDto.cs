using BusinessLogic.Models.Ads;
using CrudAutomaticBusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models.Users
{
    public class UserDto : IdentifyableDto
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserAddress { get; set; }
        public int IdRole { get; set; }
        public int? IdTown { get; set; }
    }

    public class ReadUserDto : IdentifyableDto
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserAddress { get; set; }
        public string RoleName { get; set; }
        public string TownName { get; set; }
        public IEnumerable<MicroAdDto> Ads { get; set; }
    }

    public class MicroAdDto
    {
        public string VehicleName { get; set; }
        public string User { get; set; }
        public decimal Price { get; set; }
    }
}
