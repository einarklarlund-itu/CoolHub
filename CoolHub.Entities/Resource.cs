using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolHub.Entities
{
    public class Resource
    {
        [Required(ErrorMessage = "The resource's id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The resource's name is required")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "The resource's url is required")]
        [Url]
        public string Url { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public int? TopicId { get; set; }

        [Required(ErrorMessage = "The resource's topic object is required")]
        public Topic Topic { get; set; }
    }
}