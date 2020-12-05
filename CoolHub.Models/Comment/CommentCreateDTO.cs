using CoolHub.Entities;

namespace CoolHub.Models
{
    public class CommentCreateDTO
    {
        public UserDTO User { get; set; }
        public string Text { get; set; }
    }
}