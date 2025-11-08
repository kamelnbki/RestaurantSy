using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.Data.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public EntityRoles Role { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
