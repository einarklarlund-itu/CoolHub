using CoolHub.Entities;

namespace CoolHub.Models
{
    public class CommentDetailsDTO
    {
        public UserDTO User { get; set; }
        public string Text { get; set; }
    }
}