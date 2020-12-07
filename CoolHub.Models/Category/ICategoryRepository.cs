using System.Linq;
using System.Threading.Tasks;

namespace CoolHub.Models
{
    public interface ICategoryRepository
    {
        int NumberOfCategories();
        (Status response, int categoryId) Create(CategoryCreateDTO category);
        Task<(Status response, int categoryId)> CreateAsync(CategoryCreateDTO category);
        IQueryable<CategoryDetailsDTO> Read();
        Task<IQueryable<CategoryDetailsDTO>> ReadAsync();
        CategoryDetailsDTO Read(int categoryId);
        Task<Status> Update(CategoryUpdateDTO tag);
        Task<Status> Delete(int categoryId, bool force = false);
    }
}
