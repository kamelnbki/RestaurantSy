using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data.Entity
{
    public class Category : BaseEntity
    {   
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; } = 0;
        public string ImageUrl { get; set; } = string.Empty;

        public ICollection<MenuItems> MenuItems { get; set; }
    }
}
