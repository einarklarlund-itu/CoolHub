using System.Linq;
using System.Threading.Tasks;

namespace CoolHub.Models
{
    public interface IUserRepository
    {
        int NumberOfUsers();
        (Status response, int userId) Create(UserCreateDTO user);
        UserDetailsDTO Read(int userId);
        UserDetailsDTO Read(string username);
        Status Update(UserUpdateDTO user);
        Status Delete(int userId, bool force = false);
    }
}
