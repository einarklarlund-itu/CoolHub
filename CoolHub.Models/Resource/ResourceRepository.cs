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

        public async Task<(Status response, int resourceId)> CreateAsync(ResourceCreateDTO resource)
        {
            var resourceExists = await _context.Resources.AnyAsync(c => c.Name == resource.Name);

            if (resourceExists)
            {
                return (Conflict, 0);
            }

            var entity = new Resource
            {
                Name = resource.Name,
                Description = resource.Description,
                Url = resource.Url
            };

            _context.Resources.Add(entity);
            await _context.SaveChangesAsync();

            return (Created, entity.Id);
        }
        
        public (Status response, int resourceId) Create(ResourceCreateDTO resource)
        {
            var resourceExists = _context.Resources.Any(c => c.Name == resource.Name);

            if (resourceExists)
            {
                return (Conflict, 0);
            }

            var entity = new Resource
            {
                Name = resource.Name,
                Description = resource.Description
            };

            _context.Resources.Add(entity);
            _context.SaveChanges();

            return (Created, entity.Id);
        }

        public IQueryable<ResourceDetailsDTO> Read()
        {
            return from r in _context.Resources
                select new ResourceDetailsDTO
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

        public async Task<IQueryable<ResourceDetailsDTO>> ReadAsync()
        {
            return await Task.Run(() => 
                from c in _context.Resources
                select new ResourceDetailsDTO
                {
                    Name = c.Name,
                    Description = c.Description,
                    Comments = c.Comments.Select(c => new CommentDTO()
                    {
                        Text = c.Text,
                        User = new UserDTO()
                        {
                            Name = c.User.Name
                        }
                    }).ToList()
                });
        }

        public async Task<ResourceDetailsDTO> Read(int tagId)
        {
            var tags = from c in _context.Resources
                       where c.Id == tagId
                       select new ResourceDetailsDTO
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

            return await tags.FirstOrDefaultAsync();
        }

        public async Task<Status> Update(ResourceUpdateDTO resource)
        {
            var resourceExists = await _context.Resources
                .AnyAsync(t => t.Id != resource.Id && t.Name == resource.Name);

            if (!resourceExists)
            {
                return Conflict;
            }

            var entity = await _context.Resources.FindAsync(resource.Id);

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

            await _context.SaveChangesAsync();

            return Updated;
        }

        public async Task<Status> Delete(int resourceId, bool force = false)
        {
            var entity = await _context.Resources
                .Include(c => c.Comments)
                .FirstOrDefaultAsync(c => c.Id == resourceId);

            if (entity == null)
            {
                return NotFound;
            }

            if (!force && entity.Comments.Any())
            {
                return Conflict;
            }

            _context.Resources.Remove(entity);

            await _context.SaveChangesAsync();

            return Deleted;
        }
    }
}
