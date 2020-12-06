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

            var entity = new Comment
            {
                User = new UserDTO() 
                {
                    Name = comment.User.Name
                },
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
            return from c in _context.Comments where c.ResourceId = resource.id
                select new CommentDetailsDTO
                {
                    User = c.User,
                    Text = c.Text,
                };
        }

        public async Task<IQueryable<CommentDetailsDTO>> ReadAsync(ResourceDetailsDTO resource)
        {
            return await Task.Run(() =>  from c in _context.Comments where c.ResourceId = resource.id
                select new CommentDetailsDTO
                {
                    User = c.User,
                    Text = c.Text,
                });
        }
        
        public IQueryable<CommentDetailsDTO> Read(UserDTO user)
        {
            return from c in _context.Comments where c.User.Id = 1 // TODO: maybe username? DTO does not include ID
                select new CommentDetailsDTO
                {
                    User = c.User,
                    Text = c.Text,
                };
        }

        public async Task<IQueryable<CommentDetailsDTO>> ReadAsync(UserDTO user)
        {
            return await Task.Run(() => from c in _context.Comments where c.User.Id = user.id // TODO: maybe username? DTO does not include ID
                select new CommentDetailDTO
                {
                    User = c.User,
                    Text = c.Text,
                });
        }

        public Task<Status> Update(CommentUpdateDTO comment)
        {
            var commentExist = _context.Comment.Any(c => c.Id == comment.Id);
            if (!commentExist)
            {
                return Conflict;
            }

            var entity = _context.Comment.Any(c => c.Id == comment.Id);
            if (entity == null)
            {
                return NotFound;
            }

            commentEntity.Text = comment.Text;

            await _context.SaveChangesAsync();
            return Updated;
        }
        
        public Task<Status> Delete(int commentId, bool force = false)
        {
            var entity = _context.Comment.FirstOrDefaultAsync(c => c.Id);
            if (entity == null)
            {
                return Conflict;
            }

            if (!force && entity.User) // TODO: figure out force for comments. Delete from User? Auto?
            {
                    return Conflict;
            }

            _context.Comment.Remove(entity);
            await _context.SaveChangesAsync();
            return Deleted;
        }
    }
}   
