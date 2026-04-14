

using backend.Dtos.user;
using backend.Models;

namespace backend.mappers
{
 public static class UserMappers
    {
        public static UserDto ToUserDto(this User userModel)
        {
            return new UserDto
            {
                Id=userModel.Id,
                FirstName=userModel.FirstName,
                LastName=userModel.LastName,
                DateOfBirth=userModel.DateOfBirth,
                Email=userModel.Email,
                Gender=userModel.Gender
            };
        }
        public static User ToUserFromCreateDTO(this CreateUserRequestDto userDto)
        {
            return new User
            {
                FirstName=userDto.FirstName,
                LastName=userDto.LastName,
                DateOfBirth=userDto.DateOfBirth,
                Password=userDto.Password,
                Email=userDto.Email,
                Gender=userDto.Gender,
            };
        }
    }   
}