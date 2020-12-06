using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using CoolHub.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static CoolHub.Entities.State;
using static CoolHub.Models.Status;

namespace CoolHub.Models
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ICoolHubContext _context;

        public CommentRepository(ICoolHubContext context)
        {
            _context = context;
        }

        public int NumberOfComments() //do we need this? maybe per User?
        {
            // Task.Run()
            return _context.Comments.Count();
        }

        public (Status response, int CommentId) Create(CommentCreateDTO comment)
        {
            Debug.WriteLine("Create called in CommentRepository");
            var user = _context.Users.Where(u => u.Name == comment.User.Name).FirstOrDefault();

            var entity = new Comment
            {
                User = user,
                Text = comment.Text
            };

            _context.Comments.Add(entity);
            _context.SaveChanges();
            Debug.WriteLine("_context.SaveChangesAsync returned in CommentRepository");
            return (Created, entity.Id);
        }

        public async Task<(Status response, int CommentId)> CreateAsync(CommentCreateDTO comment) // TODO: CommentCreateDTO take UserDTO??
        {
            Debug.WriteLine("Create called in CommentRepository");

            var entity = new Comment
            {
                User = new User
            {
                Name = comment.User.Name,
                Email = comment.User.Name + "@hotmail.dk"
            },
                Text = comment.Text
            };

            _context.Comments.Add(entity);
            await _context.SaveChangesAsync();
            Debug.WriteLine("_context.SaveChangesAsync returned in CommentRepository");
            return await Task.Run(() => (Created, entity.Id));
        }

        public IQueryable<CommentDetailsDTO> Read(ResourceDetailsDTO resource)
        {
            return null;
            // return from c in _context.Comments where c.ResourceId = resource.id
            //     select new CommentDetailsDTO
            //     {
            //         User = c.User,
            //         Text = c.Text,
            //     };
        }

        public async Task<IQueryable<CommentDetailsDTO>> ReadAsync(ResourceDetailsDTO resource)
        {
            return null;
            // return await Task.Run(() =>  from c in _context.Comments where c.ResourceId = resource.id
            //     select new CommentDetailsDTO
            //     {
            //         User = c.User,
            //         Text = c.Text,
            //     });
        }
        
        public IQueryable<CommentDetailsDTO> Read(UserDTO user)
        {
           return null;
            // return from c in _context.Comments where c.User.Id = 1 // TODO: maybe username? DTO does not include ID
            //     select new CommentDetailsDTO
            //     {
            //         User = c.User,
            //         Text = c.Text,
            //     };
        }

        public async Task<IQueryable<CommentDetailsDTO>> ReadAsync(UserDTO user)
        {
            return null;
            // return await Task.Run(() => from c in _context.Comments where c.User.Id = -1 // TODO: maybe username? DTO does not include ID
            //     select new CommentDetailsDTO
            //     {
            //         User = c.User,
            //         Text = c.Text,
            //     });
        }

        public Task<Status> Update(CommentUpdateDTO comment)
        {
            return null;
            // var commentExist = _context.Comments.Any(c => c.Id == comment.Id);
            // if (!commentExist)
            // {
            //     return  Task.Run(() => Conflict);
            // }

            // var commentEntity = _context.Comments.Any(c => c.Id == comment.Id);
            // if (commentEntity == null)
            // {
            //     return Task.Run(() => NotFound);
            // }

            // commentEntity.Text = comment.Text;

            // await _context.SaveChangesAsync();
            // return  Task.Run(() => Updated);
        }
        
        public Task<Status> Delete(int commentId, bool force = false)
        {
            return null;
            // var entity = _context.Comments.FirstOrDefaultAsync(c => c.Id);
            // if (entity == null)
            // {
            //     return  Task.Run(() => Conflict);
            // }

            // if (!force && entity.User) // TODO: figure out force for comments. Delete from User? Auto?
            // {
            //         return  Task.Run(() => Conflict);
            // }

            // _context.Comments.Remove(entity);
            // await _context.SaveChangesAsync();
            // return  Task.Run(() => Deleted);
        }
    }
}   
