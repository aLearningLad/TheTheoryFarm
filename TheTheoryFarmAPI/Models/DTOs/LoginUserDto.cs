using System.ComponentModel.DataAnnotations;

namespace TheTheoryFarmAPI.Models.DTOs
{
    public class LoginUserDto
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
