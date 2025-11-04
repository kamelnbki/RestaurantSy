using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Restaurant.Data.Entity;
using Restaurant.Interface;
using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
           optionsBuilder.UseSqlServer("Server=DESKTOP-Q5O3N70\\MXMSERVER;Database=RESTURANT_DB_2;Integrated Security=true;TrustServerCertificate=true;");

        public DbSet<User> Users { get; set; }
        public DbSet<Tables> Tables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<MenuItems> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
            builder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Admin",
                UserName = "admin",
                Password = "12345",
                Role = UserRoles.Admin,
                Created = new DateTime(2025, 01, 01),
                CreatedBy = "System",
                Status = EntityStatus.Active,
                Notes = "Default system admin"
            });
        }
    }
}
