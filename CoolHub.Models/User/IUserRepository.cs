using System.Linq;
using System.Threading.Tasks;

namespace CoolHub.Models
{
    public interface IUserRepository
    {
        int NumberOfUsers();
        (Status response, int userId) Create(UserCreateDTO user);
        Task<(Status response, int userId)> CreateAsync(UserCreateDTO user);
        Task<UserDetailsDTO> Read(int userId);
        Task<Status> Update(UserUpdateDTO user);
        Task<Status> Delete(int userId, bool force = false);
    }
}
