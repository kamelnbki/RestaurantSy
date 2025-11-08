using Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.Services
{

    public class CurrentUserService
    {
       public static int UserId { get; set; }
       public static string Name { get; set; }
       public static EntityRoles Role { get; set; }

    }
}
