using SolArch.BusinessLogic.Interfaces;
using SolArch.BusinessLogic.Models;
using System.Threading.Tasks;

namespace SolArch.DataAccess.EfCore.Services
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
