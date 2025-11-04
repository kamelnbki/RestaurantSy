using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.Data.Entity
{
    public class Order : BaseEntity
    {
        public int TableId { get; set; }
        public Tables Table { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public int OrderNumber { get; set; }
        public DateTime? ConfirmedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
