using System.ComponentModel.DataAnnotations;

namespace TheTheoryFarmAPI.Models.DTOs
{
    public class TheoryDto
    {
        [Required]
        [MaxLength(40, ErrorMessage = "The joke's title cannot be longer than 40 characters")]
        public string Title { get; set; }

        [Required]
        [MinLength(50, ErrorMessage = "The joke's length cannot be shorter than 50 characters")]
        [MaxLength(250, ErrorMessage = "The joke's length cannot be longer than 250 characters")]
        public string TheoryBody { get; set; }

        public DateTime PublishedDate { get; set; } = DateTime.UtcNow; // sets date automatically when theory object is instantiated. Great
    }
}
