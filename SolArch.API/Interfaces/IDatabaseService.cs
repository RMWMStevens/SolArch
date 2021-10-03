using SolArch.BL.Models;
using System.Threading.Tasks;

namespace SolArch.API.Interfaces
{
    public interface IDatabaseService
    {
        public Task AddUserAsync(User user);
    }
}
