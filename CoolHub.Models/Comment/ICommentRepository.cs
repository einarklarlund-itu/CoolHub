using System.Linq;
using System.Threading.Tasks;

namespace CoolHub.Models
{
    public interface ICommentRepository
    {
        (Status response, int CommentId) Create(CommentCreateDTO comment);
        IQueryable<CommentDetailsDTO> Read(ResourceDetailsDTO resource);
        IQueryable<CommentDetailsDTO> Read(UserDTO User);
        Status Update(CommentUpdateDTO tag);
        Status Delete(int commentId, bool force = false);
    }
}
