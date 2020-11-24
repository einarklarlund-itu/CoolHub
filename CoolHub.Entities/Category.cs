using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolHub.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Topic> Topics { get; set; }
    }
}