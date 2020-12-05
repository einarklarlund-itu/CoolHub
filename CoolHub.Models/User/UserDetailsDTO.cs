using System.Collections.Generic;
using CoolHub.Entities;

namespace CoolHub.Models
{
    public class UserDetailsDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
    }
}