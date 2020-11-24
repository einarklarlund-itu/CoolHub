using System.Collections.Generic;

namespace CoolHub.Models
{
    public class ResourceUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<CommentDTO> Comments { get; set; }
    }
}