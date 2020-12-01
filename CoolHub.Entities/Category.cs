using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolHub.Entities
{
    public class Category
    {
        [Required(ErrorMessage = "The category's id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The category's name is required")]
        public string Name { get; set; }

        public string Description { get; set; }
        
        public ICollection<Topic> Topics { get; set; }
    }
}