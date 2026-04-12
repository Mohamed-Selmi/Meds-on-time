
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class User
    {
        public int Id { get; set;}
        public string FirstName { get; set;} = string.Empty;

        public string LastName {get; set;}= string.Empty;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedOn { get; set;}= DateTime.Now;
        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth{ get; set;}
        [Required]
        public string? Gender { get; set;}
        [Required]
        public string Email { get; set;} = string.Empty;
        [Required]
        public string Password {get; set;} = string.Empty;

        public int Age {get; set;}

        
        
    }
}