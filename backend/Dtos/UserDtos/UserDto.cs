

namespace backend.Dtos.userDtos
{
    
    public class UserDto
    {
        public int Id { get; set;}
        public string FirstName { get; set;} = string.Empty;

        public string LastName {get; set;}= string.Empty; 

        public DateOnly DateOfBirth{ get; set;}

         public string Email { get; set;} = string.Empty;

        public string? Gender { get; set;}
    }
}