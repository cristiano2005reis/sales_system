using System;
using System.Data.Entity;
using Business.Entities;

namespace Business.Contexts
{
    public class GenericContext: DbContext
    {
        public GenericContext():base("sales_system")
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Operation> Operation { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User { get; set; }
    }
}
