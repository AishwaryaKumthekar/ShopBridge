using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("(?=.*[a-z])(?=.*[A-Z])"
        , ErrorMessage="Password must have least 6 characters long.")]
        public string Password { get; set; }
    }
}