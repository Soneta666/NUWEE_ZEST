using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    internal class NUWEE_ZEST_DbContext : DbContext
    {
        public NUWEE_ZEST_DbContext() : base() { }
        public NUWEE_ZEST_DbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connStr = "Data Source = mongodb+srv://user:<rkZzIpakzO67cStz>@cluster.3gaoi.mongodb.net/";
            optionsBuilder.UseSqlServer(connStr);
        }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBasket> ProductBaskets { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
