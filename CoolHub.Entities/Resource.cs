using System.Collections.Generic;

namespace CoolHub.Entities
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public Topic Topic { get; set; }
    }
}