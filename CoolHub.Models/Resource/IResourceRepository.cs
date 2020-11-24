using System.Linq;
using System.Threading.Tasks;

namespace CoolHub.Models
{
    public interface IResourceRepository
    {
        int NumberOfResources();
        (Status response, int resourceId) Create(ResourceCreateDTO resource);
        Task<(Status response, int resourceId)> CreateAsync(ResourceCreateDTO resource);
        IQueryable<ResourceDetailsDTO> Read();
        Task<IQueryable<ResourceDetailsDTO>> ReadAsync();
        Task<ResourceDetailsDTO> Read(int resourceId);
        Task<Status> Update(ResourceUpdateDTO resource);
        Task<Status> Delete(int resourceId, bool force = false);
    }
}
