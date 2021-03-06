using System.Collections.Generic;
using CoolHub.Entities;

namespace CoolHub.Models
{
    public class TopicDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ResourceDTO> Resources { get; set; }
    }
}