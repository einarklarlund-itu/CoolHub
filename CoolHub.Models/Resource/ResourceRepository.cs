using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using CoolHub.Entities;
using Microsoft.EntityFrameworkCore;
using static CoolHub.Entities.State;
using static CoolHub.Models.Status;

namespace CoolHub.Models
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly ICoolHubContext _context;

        public ResourceRepository(ICoolHubContext context)
        {
            _context = context;
        }

        public int NumberOfResources()
        {
            // Task.Run()
            return _context.Resources.Count();
        }
        
        public (Status response, int resourceId) Create(ResourceCreateDTO resource)
        {
            var resourceExists = _context.Resources.Any(c => c.Name == resource.Name);

            if (resourceExists)
            {
                return (Conflict, 0);
            }

            var entity = new Resource()
            {
                Name = resource.Name,
                Description = resource.Description,
                Topic = _context.Topics.Find(resource.TopicId),
                Url = resource.Url
            };

            _context.Resources.Add(entity);
            _context.SaveChanges();

            return (Created, entity.Id);
        }

        public IQueryable<ResourceDetailsDTO> Read()
        {
            return from r in _context.Resources
                select new ResourceDetailsDTO()
                {
                    Name = r.Name,
                    Description = r.Description,
                    Comments = r.Comments.Select(c => new CommentDTO()
                    {
                        Text = c.Text,
                        User = new UserDTO()
                        {
                            Name = c.User.Name
                        }
                    }).ToList()
                };
        }

        public ResourceDetailsDTO Read(int resourceId)
        {
            var tags = from c in _context.Resources
                       where c.Id == resourceId
                       select new ResourceDetailsDTO()
                       {
                           Name = c.Name,
                           Description = c.Description,
                           Comments = c.Comments.Select(c => new CommentDTO
                           {
                               Text = c.Text,
                               User = new UserDTO()
                               {
                                   Name = c.User.Name
                               }
                           }).ToList()
                       };

            return tags.FirstOrDefault();
        }

        public Status Update(ResourceUpdateDTO resource)
        {
            var resourceExists = _context.Resources
                .Any(t => t.Id != resource.Id && t.Name == resource.Name);

            if (!resourceExists)
            {
                return Conflict;
            }

            var entity = _context.Resources.Find(resource.Id);

            if (entity == null)
            {
                return NotFound;
            }

            entity.Name = resource.Name;
            entity.Description = resource.Description;
            entity.Comments = _context.Comments
                .Where(c1 => resource.Comments.Any(c2 => 
                    c1.Id == c2.Id))
                .ToList();

            _context.SaveChanges();

            return Updated;
        }

        public Status Delete(int resourceId, bool force = false)
        {
            var entity = _context.Resources
                .Include(c => c.Comments)
                .FirstOrDefault(c => c.Id == resourceId);

            if (entity == null)
            {
                return NotFound;
            }

            if (!force && entity.Comments.Any())
            {
                return Conflict;
            }

            _context.Resources.Remove(entity);

            _context.SaveChanges();

            return Deleted;
        }
    }
}
