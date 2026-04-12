
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class User
    {
        private int Id { get; set;}
        private string FirstName { get; set;} = string.Empty;

        private string LastName {get; set;}= string.Empty;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private DateTime CreatedOn { get; set;}= DateTime.Now;
        [Required]
        private DateTime? DateOfBirth{ get; set;}
        [Required]
        private string? Gender { get; set;}
        [Required]
        private string Email { get; set;} = string.Empty;
        [Required]
        private string Password {get; set;} = string.Empty;

        private int Age {get; set;}

        
        
    }
}