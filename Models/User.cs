using System.ComponentModel.DataAnnotations;

namespace Museum.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; } // В реальном приложении пароль должен быть захеширован
    }

}
