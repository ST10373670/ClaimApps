using System.ComponentModel.DataAnnotations;

namespace ClaimApps.Models
{
    public class Claim
    {
        [Key]
        public int ClaimId { get; set; }

        public string FirstName { get; set; }

        [Required]

        public string? Surname { get; set; }

        public string Email { get; set; }

        public string LectureName { get; set; }

        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        
        public string PhoneNumberConfirmed { get; set;}
        public string EmailConfirmed { get; set;}
        public string PasswordConfirmed { get; set;}

        public DateTime HireDate { get; set;}
    }
}
