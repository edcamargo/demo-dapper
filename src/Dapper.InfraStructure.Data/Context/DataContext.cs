using Dapper.Domain.Entities.Customers;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Dapper.InfraStructure.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Customer> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Mappings
            // modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
