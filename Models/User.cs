using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

}
