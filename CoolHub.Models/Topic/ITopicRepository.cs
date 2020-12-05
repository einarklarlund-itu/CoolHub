using System.Linq;
using System.Threading.Tasks;

namespace CoolHub.Models
{
    public interface ITopicRepository
    {
        int NumberOfTopics();
        (Status response, int topicId) Create(TopicCreateDTO topic);
        Task<(Status response, int topicId)> CreateAsync(TopicCreateDTO topic);
        IQueryable<TopicDetailsDTO> Read();
        Task<IQueryable<TopicDetailsDTO>> ReadAsync();
        Task<TopicDetailsDTO> Read(int topicId);
        Task<Status> Update(TopicUpdateDTO topic);
        Task<Status> Delete(int topicId, bool force = false);
    }
}
