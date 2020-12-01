using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolHub.Entities
{
    public class User
    {
        [Required(ErrorMessage = "The user's id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The user's username is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The user's email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}