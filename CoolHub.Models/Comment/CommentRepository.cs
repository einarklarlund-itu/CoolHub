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

            var entity = new Comment()
            {
                User = _context.Users.Find(comment.UserId),
                Text = comment.Text
            };

            _context.Comments.Add(entity);
            _context.SaveChanges();
            Debug.WriteLine("_context.SaveChangesAsync returned in CommentRepository");
            return (Created, entity.Id);
        }

        public IQueryable<CommentDetailsDTO> Read(ResourceDetailsDTO resource)
        {
            return from c in _context.Comments where c.ResourceId == resource.id
                select new CommentDetailsDTO()
                {
                    User = new UserDTO() {
                        Name = c.User.Name
                    },
                    Text = c.Text,
                };
        }
        
        public IQueryable<CommentDetailsDTO> Read(UserDTO user)
        {
            return from c in _context.Comments where c.User.Name == user.Name // TODO: maybe username? DTO does not include ID
                select new CommentDetailsDTO()
                {
                    User = new UserDTO() {
                        Name = c.User.Name
                    },
                    Text = c.Text,
                };
        }

        public Status Update(CommentUpdateDTO comment)
        {
            var commentExist = _context.Comments.Any(c => c.Id == comment.Id);
            if (!commentExist)
            {
                return  Conflict;
            }

            var commentEntity = _context.Comments.FirstOrDefault(c => c.Id == comment.Id);
            if (commentEntity == null)
            {
                return NotFound;
            }

            commentEntity.Text = comment.Text;

            _context.SaveChanges();
            return Updated;
        }
        
        public Status Delete(int commentId, bool force = false)
        {
            var entity = _context.Comments.FirstOrDefault(c => c.Id == commentId);
            if (entity == null)
            {
                return Conflict;
            }

            if (!force) // TODO: figure out force for comments. Delete from User? Auto?
            {
                    return  Conflict;
            }

            _context.Comments.Remove(entity);
            _context.SaveChanges();
            return  Deleted;
        }
    }
}   
