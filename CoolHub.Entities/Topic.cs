using System.Collections.Generic;

namespace CoolHub.Entities
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public Category Category { get; set; }
    }
}