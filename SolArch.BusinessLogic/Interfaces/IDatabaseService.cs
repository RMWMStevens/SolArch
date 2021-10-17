using SolArch.BusinessLogic.Models;
using System.Threading.Tasks;

namespace SolArch.BusinessLogic.Interfaces
{
    public interface IDatabaseService
    {
        public Task AddUserAsync(User user);
    }
}
