using CoolHub.Entities;

namespace CoolHub.Models
{
    public class CommentCreateDTO
    {
        public int UserId { get; set; }
        public string Text { get; set; }
    }
}