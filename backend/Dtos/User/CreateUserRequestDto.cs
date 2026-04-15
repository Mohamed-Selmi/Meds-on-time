namespace backend.Dtos.user
{
    public class CreateUserRequestDto
    {
        //this is actually the same as update user for now as I'm still unsure how to calculate the age dynamically.
         public string FirstName { get; set;} = string.Empty;

        public string LastName {get; set;}= string.Empty; 

        public string Password {get; set;} = string.Empty;

        public DateOnly DateOfBirth{ get; set;}

         public string Email { get; set;} = string.Empty;

        public string? Gender { get; set;}
    }
}