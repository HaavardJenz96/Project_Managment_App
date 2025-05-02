using Microsoft.EntityFrameworkCore;
using ProjectManagment.Data.Enteties;

namespace EFCoreExample
{
    public class AppDbContext : DbContext
    {
        public DbSet<CustomerEntity> customers { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }
    }
}
