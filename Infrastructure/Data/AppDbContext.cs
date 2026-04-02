using AppropriationOfHouseWork.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppropriationOfHouseWork.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<HouseworkLog> HouseworkLogs => Set<HouseworkLog>();
    }
}
