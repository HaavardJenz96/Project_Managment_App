using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ProjectManagment.Data.Enteties;
using ProjectManagment.Data.Entities;


namespace EFCoreExample
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<ViewAccountManagers> AccountManagersView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
          .Entity<ViewAccountManagers>(
              eb =>
              {
                  eb.HasNoKey();
                  eb.ToView("View_AccountManagers");
                  
              });
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
    }
}
