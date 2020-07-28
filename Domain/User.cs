using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.DatabaseModels
{
    public class User : BaseModel 
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserAddress { get; set; }
        public int IdRole { get; set; }
        public int? IdTown { get; set; }
        public virtual Role Role { get; set; }
        public virtual Town Town { get; set; }  
        public virtual ICollection<Ad> Ads { get; set; }
    }
}
