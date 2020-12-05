using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using CoolHub.Entities;
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

        public int NumberOfComments()
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
                    comment.User
                },
                Text = comment.Text
            };

            _context.Comments.Add(entity);
            _context.SaveChanges();
            Debug.WriteLine("_context.SaveChangesAsync returned in CommentRepository");
            return (Created, entity.Id);
        }

        public Task<(Status response, int CommentId)> CreateAsync(CommentCreateDTO comment)
        {
            Debug.WriteLine("Create called in CommentRepository");

            var entity = new Comment
            {
                User = comment.User,
                Text = comment.Text
            };

            _context.Comments.Add(entity);
            await _context.SaveChangesAsync();
            Debug.WriteLine("_context.SaveChangesAsync returned in CommentRepository");
            return (Created, entity.Id);
        }

        public IQueryable<CommentDetailsDTO> Read(ResourceDetailsDTO resource)
        {
            return from c in _context.Comments where c.ResourceId = resource.id
                select new CommentDetailDTO
                {
                    Name = c.Name,
                    Description = c.Description,
                };
        }

        public Task<IQueryable<CommentDetailsDTO>> ReadAsync(ResourceDetailsDTO resource)
        {
            return null;
        }
        
        public IQueryable<CommentDetailsDTO> Read(UserDTO user)
        {
            return null;
        }

        public Task<IQueryable<CommentDetailsDTO>> ReadAsync(UserDTO user)
        {
            return null;
        }

        public Task<Status> Update(CommentUpdateDTO tag)
        {
            return null;
        }
        
        public Task<Status> Delete(int commentId, bool force = false)
        {
            return null;
        }
    }
}   
