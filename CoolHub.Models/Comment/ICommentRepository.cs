using System.Linq;
using System.Threading.Tasks;

namespace CoolHub.Models
{
    public interface ICommentRepository
    {
        (Status response, int CommentId) Create(CommentCreateDTO comment);
        Task<(Status response, int CommentId)> CreateAsync(CommentCreateDTO comment);
        IQueryable<CommentDetailsDTO> Read(ResourceDetailsDTO resource);
        Task<IQueryable<CommentDetailsDTO>> ReadAsync(ResourceDetailsDTO resource);
        IQueryable<CommentDetailsDTO> Read(UserDTO User);
        Task<IQueryable<CommentDetailsDTO>> ReadAsync(UserDTO User);
        Task<Status> Update(CommentUpdateDTO tag);
        Task<Status> Delete(int commentId, bool force = false);
    }
}
