using SolArch.API.Interfaces;
using SolArch.BL.Models;
using System.Threading.Tasks;

namespace SolArch.DAL.EF.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly AppDbContext dbContext;

        public DatabaseService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddUserAsync(User user)
        {
            await dbContext.AddAsync(user);
        }
    }
}
