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

        public int NumberOfUsers()
        {
            return _context.Users.Count();
        }

        public (Status response, int userId) Create(UserCreateDTO user){

            return (Conflict, -1);

            // var userExist = _context.Users.Any(u => u.Email == user.Email);
            // if (userExist)
            // {
            //     return (Conflict, 0);
            // }

            // var entity = new User
            // {
            //     Name = user.Name,
            //     Email = user.Email
            // };
            // _context.Users.Add(entity);
            // _context.SaveChanges();

            // return (Created, entity.Id);
            
        }
        
        public Task<(Status response, int userId)> CreateAsync(UserCreateDTO user)
        {
            return Task.Run(() => (Conflict, -1));   
        }

        public Task<UserDetailsDTO> Read(int userId)
        {
            
            // var user = from u in _context.Users
            //            where u.Id == userId
            //            select new UserDetailsDTO
            //            {
            //                Name = u.Name,
            //                Email = u.Email,
            //                Comments = null
            //            };
            // return Task.Run(() => user);
            return null;
        }
            
        public async Task<Status> Update(UserUpdateDTO user) // TODO: why task and asyyyync?
        {
            // var userExist = _context.Users.Any(u => u.Email == user.Email);
            // if (!userExist)
            // {
            //     return Task.Run(() => Conflict);
            // }

            // var entity = _context.Users.Any(u => u.Email == user.Email); // TODO: this is boolean?
            // if (entity == null)
            // {
            //     return Task.Run(() => NotFound);
            // }

            // // TODO: entity is boolean - this is fuckeddd

            // // entity.Name = user.Name;
            // // entity.Email = user.Email;
            // // entity.Comments = _context.Comments
            // // .Where(c => user.Comments.Any(q => q.Id == c.Id)
            // // .ToList());

            // await _context.SaveChangesAsync();
            return await Task.Run(() => Updated);
        }

        public async Task<Status> Delete(int userId, bool force = false)
        {
            // var entity = _context.Users.FirstOrDefaultAsync(u => u.Id); // TODO: why async?
            // if (entity == null)
            // {
            //     return await Task.Run(() =>Conflict);
            // }

            // if (!force && entity.Comments.Any())
            // {
            //         return await Task.Run(() =>Conflict);
            // }

            // _context.Users.Remove(entity);
            // await _context.SaveChangesAsync(); // TODO: why async?
            return await Task.Run(() => Deleted);
        }
    }
}

