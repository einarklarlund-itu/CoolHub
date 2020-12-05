using CoolHub.Entities;

namespace CoolHub.Models
{
    public class CommentDetailsDTO
    {
        public int Id { get; set; }
        public UserDTO User { get; set; }
        public string Text { get; set; }
    }
}