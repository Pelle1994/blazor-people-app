using System.ComponentModel.DataAnnotations;

namespace PeopleApp.Models
{
    public class PersonDto
    {
        [Required]
        [StringLength(20, ErrorMessage = "First name too long.")]
        [MinLength(2, ErrorMessage = "First name too short.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Last name too long.")]
        [MinLength(2, ErrorMessage = "Last name too short.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAdress { get; set; }
    }
}
