using System.Linq;
using System.Threading.Tasks;
using CoolHub.Entities;
using static CoolHub.Models.Status;

namespace CoolHub.Models {
    public class TopicRepository : ITopicRepository
    {
        private readonly ICoolHubContext _context;

        public TopicRepository(ICoolHubContext context)
        {
            _context = context;
        }

        public int NumberOfTopics()
        {
            return _context.Topics.Count();
        }

        public (Status response, int topicId) Create(TopicCreateDTO topic)
        {
            return (Conflict, -1);
        }

        public Task<(Status response, int topicId)> CreateAsync(TopicCreateDTO topic)
        {
            return Task.Run(() => (Conflict, -1));
        }

        public IQueryable<TopicDetailsDTO> Read()
        {
            return from t in _context.Topics
                select new TopicDetailsDTO
                {
                    Name = t.Name,
                    Description = t.Description
                };
        }

        public async Task<IQueryable<TopicDetailsDTO>> ReadAsync()
        { 
            return await Task.Run(() =>
                (from t in _context.Topics
                select new TopicDetailsDTO
                {
                    Name = t.Name,
                    Description = t.Description
                }).ToListAsync());
        }

        public async Task<TopicDetailsDTO> Read(string topicName) // TODO: why task (needs async?)
        {
            return await Task.Run(() =>
                _context.Topics.Select(t => new TopicDetailsDTO{Name = t.Name,
                                                                Description = t.Description,
                                                                Resources = t.Resources.Select(new ResourceDTO{
                                                                }).ToList()}).Where(t => t.Name == topicName));
        }

        
        public Task<TopicDetailsDTO> Read(int id)
        {
            return null;
        }

        public async Task<Status> Update(TopicUpdateDTO topic) // TODO: why await? needs async
        {
            var topicExists = await _context.Topics
                .Any(t => t.Id != category.Id && t.Name == category.Name);

            if (!topicExists)
            {
                return await Task.Run(() => Conflict);
            }

            var entity = await _context.Topics.FindAsync(topic.Id);

            if (entity == null)
            {
                return await Task.Run(() =>NotFound);
            }

            entity.Name = topic.Name;
            entity.Description = topic.Description;
            entity.Resources = _context.Resources
                .Where(t1 => category.Resources.Any(t2 => 
                    t1.Name == t2.Name))
                .ToList();

            await _context.SaveChangesAsync();

            return Updated;
        }

        public Task<Status> Delete(int topicId, bool force = false)
        {
            //TODO: Consider deleting resources
                var entity = await _context.Topics
                .Include(c => c.Resources) // Should we also delete all the resources on a topic?
                .FirstOrDefaultAsync(c => c.Id == topicId);

            if (entity == null)
            {
                return NotFound;
            }

            if (!force && entity.Topics.Any())
            {
                return Conflict;
            }

            _context.Topics.Remove(entity);

            await _context.SaveChangesAsync();

            return Deleted;
        }
    }
}