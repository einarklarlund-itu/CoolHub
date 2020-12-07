using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using CoolHub.Entities;
using Microsoft.EntityFrameworkCore;
using static CoolHub.Entities.State;
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
            var entity = new Topic
            {
                Name = topic.Name,
                Description = topic.Description,
                Category = _context.Categories.Find(topic.CategoryId)
            };

            _context.Topics.Add(entity);
            _context.SaveChanges();
            
            return (Status.Created, entity.Id);
        }

        public Task<(Status response, int topicId)> CreateAsync(TopicCreateDTO topic)
        {
            return null;
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

        public Task<IQueryable<TopicDetailsDTO>> ReadAsync()
        { 
            return null;
        }

        public TopicDetailsDTO Read(string topicName)
        {
            return _context.Topics.Select(t => new TopicDetailsDTO()
                {
                    Name = t.Name,
                    Description = t.Description,
                    Resources = t.Resources.Select(r => new ResourceDTO()
                    {
                        Name = r.Name,
                        Description = r.Description 
                    }).ToList()
                }).Where(t => t.Name == topicName)
                .FirstOrDefault();
        }

        
        public Task<TopicDetailsDTO> Read(int id)
        {
            return null;
        }

        public Status Update(TopicUpdateDTO topic)
        {
            var topicExists = _context.Topics.Any(t => 
                t.Id != topic.Id && t.Name == topic.Name);

            if (!topicExists)
            {
                return Status.Conflict;
            }

            var entity = _context.Topics.Find(topic.Id);

            if (entity == null)
            {
                return Status.NotFound;
            }

            entity.Name = topic.Name;
            entity.Description = topic.Description;
            entity.Resources = _context.Resources
                .Where(t1 => topic.Resources.Any(t2 => 
                    t1.Name == t2.Name))
                .ToList();

            _context.SaveChanges();

            return Updated;
        }

        public Status Delete(int topicId, bool force = false)
        {
            //TODO: Consider deleting resources
                var entity = _context.Topics
                .Include(c => c.Resources) // Should we also delete all the resources on a topic?
                .FirstOrDefault(c => c.Id == topicId);

            if (entity == null)
            {
                return NotFound;
            }

            if (!force && entity.Resources.Any())
            {
                return Conflict;
            }

            _context.Topics.Remove(entity);

            _context.SaveChanges();

            return Deleted;
        }
    }
}