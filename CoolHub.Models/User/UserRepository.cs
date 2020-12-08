using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using CoolHub.Entities;
using Microsoft.EntityFrameworkCore;
using static CoolHub.Entities.State;
using static CoolHub.Models.Status;

namespace CoolHub.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly ICoolHubContext _context;

        public UserRepository(ICoolHubContext context)
        {
            _context = context;
        }

        public int NumberOfUsers()
        {
            return _context.Users.Count();
        }

        public (Status response, int userId) Create(UserCreateDTO user){
            var userExist = _context.Users.Any(u => u.Email == user.Email);
            if (userExist)
            {
                return (Conflict, 0);
            }

            var entity = new User()
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
            _context.Users.Add(entity);
            _context.SaveChanges();

            return (Created, entity.Id);
            
        }

        public UserDetailsDTO Read(int userId)
        {
            
            var user = from u in _context.Users
                       where u.Id == userId
                       select new UserDetailsDTO()
                       {
                           Name = u.Name,
                           Email = u.Email,
                           Password = u.Password,
                           Comments = u.Comments.Select(c => new CommentDTO() {
                               Id = c.Id,
                               User = new UserDTO() {
                                   Name = c.User.Name,
                               },
                               Text = c.Text
                           }).ToList()
                       };
            return user.FirstOrDefault();
        }

        public UserDetailsDTO Read(string userName)
        {
            
            var user = from u in _context.Users
                       where u.Name == userName
                       select new UserDetailsDTO()
                       {
                           Name = u.Name,
                           Email = u.Email,
                           Password = u.Password,
                           Comments = u.Comments.Select(c => new CommentDTO() {
                               Id = c.Id,
                               User = new UserDTO() {
                                   Name = c.User.Name,
                               },
                               Text = c.Text
                           }).ToList()
                       };
            return user.FirstOrDefault();
        }
            
        public Status Update(UserUpdateDTO user)
        {
            var userExist = _context.Users.Any(u => u.Email == user.Email);
            if (!userExist)
            {
                return Conflict;
            }

            var entity = _context.Users.FirstOrDefault(u => u.Email == user.Email);
            if (entity == null)
            {
                return NotFound;
            }

            entity.Name = user.Name;
            entity.Email = user.Email;
            entity.Comments = _context.Comments
            .Where(c => user.Comments.Any(q => q.Id == c.Id)).ToList();

            _context.SaveChanges();
            return Updated;
        }

        public Status Delete(int userId, bool force = false)
        {
            var entity = _context.Users.FirstOrDefault(u => u.Id == userId);
            if (entity == null)
            {
                return Conflict;
            }

            if (!force && entity.Comments.Any())
            {
                    return Conflict;
            }

            _context.Users.Remove(entity);
            _context.SaveChanges();
            return Deleted;
        }
    }
}