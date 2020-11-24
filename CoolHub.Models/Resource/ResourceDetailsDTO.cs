using System.Collections.Generic;
using CoolHub.Entities;

namespace CoolHub.Models
{
    public class ResourceDetailsDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
    }
}