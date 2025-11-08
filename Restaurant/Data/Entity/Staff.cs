using static Restaurant.Data.Enums.Enums;

namespace Restaurant.Data.Entity
{
    public class Staff : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public EntityRoles Role { get; set; }
    }
}