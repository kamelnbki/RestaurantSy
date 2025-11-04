using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Enums
{
    public class Enums
    {
        public enum UserRoles
        {
            Admin, Manager, Cashier, Waiter, Customer,
        }
        public enum TableStatus
        {
            Available, Occupied, Reserved, OutOfService
        }
        public enum OrderStatus
        {
            Pending, InProgress, Completed, Cancelled
        }
        public enum EntityStatus
        {
            Active, InActive, Deleted
        }

    }
}
