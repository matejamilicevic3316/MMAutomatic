using System;
using System.Collections.Generic;
using System.Text;

namespace CarStoreDatabaseAccess.DatabaseModels
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
