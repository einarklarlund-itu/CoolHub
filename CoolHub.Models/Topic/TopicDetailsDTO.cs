using System.Collections.Generic;
using CoolHub.Entities;

namespace CoolHub.Models
{
    public class TopicDetailsDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Resource> Resources { get; set; }
    }
}