using System.Collections.Generic;

namespace CoolHub.Entities
{
    public class Topic
    {
        [Required(ErrorMessage = "The topic's id is required")]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "The topic's name is required")]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Resource> Resources { get; set; }
        
        public int CategoryId;

        [Required(ErrorMessage = "The topic's category object is required")]
        public Category Category { get; set; }
    }
}