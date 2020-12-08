using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using CoolHub.Entities;
using Microsoft.EntityFrameworkCore;
using static CoolHub.Entities.State;
using static CoolHub.Models.Status;

namespace CoolHub.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ICoolHubContext _context;

        public CategoryRepository(ICoolHubContext context)
        {
            _context = context;
        }

        public int NumberOfCategories()
        {
            // Task.Run()
            return _context.Categories.Count();
        }

        public async Task<(Status response, int categoryId)> CreateAsync(CategoryCreateDTO category)
        {
            var categoryExists = await _context.Categories.AnyAsync(c => c.Name == category.Name);
            if (categoryExists)
            {
                return (Conflict, 0);
            }

            var entity = new Category
            {
                Name = category.Name,
                Description = category.Description
            };

            _context.Categories.Add(entity);
            await _context.SaveChangesAsync();
            return (Created, entity.Id);
        }
        
        public (Status response, int categoryId) Create(CategoryCreateDTO category)
        {
            var categoryExists = _context.Categories.Any(c => c.Name == category.Name);

            if (categoryExists)
            {
                return (Conflict, 0);
            }

            var entity = new Category
            {
                Name = category.Name,
                Description = category.Description
            };

            _context.Categories.Add(entity);
            _context.SaveChanges();

            return (Created, entity.Id);
        }

        public IQueryable<CategoryDetailsDTO> Read()
        {
            return from c in _context.Categories
                select new CategoryDetailsDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    Topics = c.Topics.Select(t => new TopicDTO()
                    {
                        Name = t.Name,
                        Description = t.Description
                    }).ToList()
                };
        }

        public async Task<IQueryable<CategoryDetailsDTO>> ReadAsync()
        {
            return await Task.Run(() => 
                from c in _context.Categories
                select new CategoryDetailsDTO
                {
                    Name = c.Name,
                    Description = c.Description,
                    Topics = c.Topics.Select(t => new TopicDTO
                    {
                        Name = t.Name,
                        Description = t.Description
                    }).ToList()
                });
        }

        public CategoryDetailsDTO Read(int categoryId)
        {
            var tags = from c in _context.Categories
                       where c.Id == categoryId
                       select new CategoryDetailsDTO
                       {
                           Name = c.Name,
                           Description = c.Description,
                           Topics = c.Topics.Select(t => new TopicDTO()
                           {
                               Id = t.Id,
                               Name = t.Name,
                               Description = t.Description,
                               Resources = t.Resources.Select(r => new ResourceDTO()
                               {
                                   Id = r.Id,
                                   Name = r.Name,
                                   Description = r.Description
                               }).ToList()
                           }).ToList()
                       };

            return tags.FirstOrDefault();
        }

        public async Task<Status> Update(CategoryUpdateDTO category)
        {
            var categoryExists = await _context.Categories
                .AnyAsync(t => t.Id != category.Id && t.Name == category.Name);

            if (!categoryExists)
            {
                return Conflict;
            }

            var entity = await _context.Categories.FindAsync(category.Id);

            if (entity == null)
            {
                return NotFound;
            }

            entity.Name = category.Name;
            entity.Description = category.Description;
            entity.Topics = _context.Topics
                .Where(t1 => category.Topics.Any(t2 => 
                    t1.Name == t2.Name))
                .ToList();

            await _context.SaveChangesAsync();

            return Updated;
        }

        public async Task<Status> Delete(int categoryId, bool force = false)
        {
            var entity = await _context.Categories
                .Include(c => c.Topics)
                .FirstOrDefaultAsync(c => c.Id == categoryId);

            if (entity == null)
            {
                return NotFound;
            }

            if (!force && entity.Topics.Any())
            {
                return Conflict;
            }

            _context.Categories.Remove(entity);

            await _context.SaveChangesAsync();

            return Deleted;
        }
    }
}
