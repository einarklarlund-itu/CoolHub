using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolHub.Entities
{
    public class Comment
    {
        [Required(ErrorMessage = "The category's id is required")]
        public int Id { get; set; }

        public string Text { get; set; }
        
        public int? UserId { get; set; }
        public User User { get; set; }
        
        public int ResourceId { get; set; }

        [Required(ErrorMessage = "The comment's resource object is required")]
        public Resource Resource { get; set; } 
    }
}