using System.Linq;
using System.Threading.Tasks;

namespace CoolHub.Models
{
    public interface ICategoryRepository
    {
        Task<(Status response, int taskId)> Create(CategoryCreateDTO category);
        IQueryable<CategoryDetailsDTO> Read();
        Task<CategoryDetailsDTO> Read(int categoryId);
        Task<Status> Update(CategoryUpdateDTO tag);
        Task<Status> Delete(int categoryId, bool force = false);
    }
}
