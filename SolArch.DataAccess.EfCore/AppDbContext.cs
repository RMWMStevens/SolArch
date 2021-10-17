using Microsoft.EntityFrameworkCore;

namespace SolArch.DataAccess.EfCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
