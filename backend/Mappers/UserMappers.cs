

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
                Age=userModel.Age,
                Email=userModel.Email,
                Gender=userModel.Gender
            };
        }
    }   
}