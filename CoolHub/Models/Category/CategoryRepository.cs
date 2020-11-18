using System.Linq;
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

        public async Task<(Status response, int taskId)> Create(CategoryCreateDTO category)
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

        public IQueryable<CategoryDetailsDTO> Read()
        {
            return from c in _context.Categories
                   select new CategoryDetailsDTO
                   {
                       Name = c.Name,
                       Description = c.Description,
                       Topics = c.Topics
                   };
        }

        public async Task<CategoryDetailsDTO> Read(int tagId)
        {
            var tags = from c in _context.Categories
                       where c.Id == tagId
                       select new CategoryDetailsDTO
                       {
                           Name = c.Name,
                           Description = c.Description,
                           Topics = c.Topics
                       };

            return await tags.FirstOrDefaultAsync();
        }

        public async Task<Status> Update(CategoryUpdateDTO category)
        {
            var categoryExists = await _context.Categories
                .AnyAsync(t => t.Id != category.Id && t.Name == category.Name);

            if (categoryExists)
            {
                return Conflict;
            }

            var entity = await _context.Categories.FindAsync(category.Id);

            if (entity == null)
            {
                return NotFound;
            }

            entity.Name = category.Name;
            entity.Name = category.Description;
            entity.Topics = _context.Topics
                .Where(c => category.Topics.Contains(c.Name))
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
