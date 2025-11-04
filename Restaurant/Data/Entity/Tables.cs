using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.Data.Entity
{
    public class Tables : BaseEntity
    {
        public string Number { get; set; }
        public int Capacity { get; set; }
        public TableStatus TableStatus { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
