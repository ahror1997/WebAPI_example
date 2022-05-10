using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class UserDTO
    {
        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
