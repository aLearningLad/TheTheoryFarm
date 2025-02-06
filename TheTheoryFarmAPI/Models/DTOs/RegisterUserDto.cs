using System.ComponentModel.DataAnnotations;

namespace TheTheoryFarmAPI.Models.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Email has to be at least 5 characters long")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password has to be at least 8 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string[] Roles { get; set; }
    }
}
