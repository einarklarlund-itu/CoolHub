using System.Linq;
using System.Threading.Tasks;

namespace CoolHub.Models
{
    public interface IResourceRepository
    {
        int NumberOfResources();
        (Status response, int resourceId) Create(ResourceCreateDTO resource);
        IQueryable<ResourceDetailsDTO> Read();
        ResourceDetailsDTO Read(int resourceId);
        Status Update(ResourceUpdateDTO resource);
        Status Delete(int resourceId, bool force = false);
    }
}
