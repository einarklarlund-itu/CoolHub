using System.Collections.Generic;
using CoolHub.Entities;

namespace CoolHub.Models
{
    public class CategoryDetailsDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}