using Microsoft.EntityFrameworkCore;
using PatikaHomework3.Data.Model;

namespace PatikaHomework3.Data.Context
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.UseSerialColumns();
        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Person> Person { get; set; }
        
    }
}
