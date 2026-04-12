using System.ComponentModel.DataAnnotations;
namespace backend.Models
{
    public class Medication
    {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Name {get; set;}= string.Empty;
        [Required]
        public string? Description {get; set;}

        public string? Type {get; set;}
        //pills, syrup or cream

        public string? SideEffects{get; set;}
    }
}