

namespace backend.Dtos.userDtos
{
    public class UpdateUserRequestDto
    {
        public string FirstName { get; set;} = string.Empty;

        public string LastName {get; set;}= string.Empty; 

        public string Password {get; set;} = string.Empty;

        public DateOnly DateOfBirth{ get; set;}

         public string Email { get; set;} = string.Empty;

        public string? Gender { get; set;}
    }

}
