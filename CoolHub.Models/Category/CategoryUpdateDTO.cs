using System.Collections.Generic;

namespace CoolHub.Models
{
    public class CategoryUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<string> Topics { get; set; }
    }
}