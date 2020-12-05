using System.Collections.Generic;

namespace CoolHub.Models
{
    public class TopicUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ResourceDTO> Resources { get; set; }
    }
}