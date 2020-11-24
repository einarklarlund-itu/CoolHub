using CoolHub.Entities;

namespace CoolHub.Models
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public UserDTO User { get; set; }
        public string Text { get; set; }
    }
}