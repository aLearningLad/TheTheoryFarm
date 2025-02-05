using System.ComponentModel.DataAnnotations;

namespace TheTheoryFarmAPI.Models.Domain
{
    public class Theory
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "The joke's title cannot be longer than 40 characters")]
        public string Title { get; set; }

        [Required]
        [MinLength(50, ErrorMessage = "The joke's length cannot be shorter than 50 characters")]
        [MaxLength(250, ErrorMessage = "The joke's length cannot be longer than 250 characters")]
        public string TheoryBody { get; set; }

        public DateTime PublishedDate { get; set; } = DateTime.UtcNow; // sets date automatically when theory object is instantiated. Great
    

        // ***** un-comment below code when starting with users class and auth later
        //public Guid CreatedById { get; set; } // foregin key --> id of user inside Users table


        // navigation property
       // public User CreatedBy { get; set; }
    
    }
}
