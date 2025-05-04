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
        public DbSet<ViewProjectStatus> ProjectStatusView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder
          .Entity<ViewAccountManagers>(
              eb =>
              {
                  eb.HasNoKey();
                  eb.ToView("View_AccountManagers");
                  
              });

            modelBuilder.Entity<ViewProjectStatus>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("View_ProjectStatus");
                    });
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
    }
}
