using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.Data.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public string CreatedBy { get; set; } 

        public DateTime? LastModified { get; set; }

        public string? LastModifiedBy { get; set; }
        public EntityStatus Status { get; set; }

        public string? Notes { get; set; }
    }
}
