using System.Collections.Generic;

namespace CoolHub.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}