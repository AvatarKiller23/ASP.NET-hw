using System.ComponentModel.DataAnnotations;

namespace JWT_Auth.Controllers
{
    public class RegistrationRequest
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
