using backend.Dtos.user;
using backend.Models;

namespace backend.Services.UserService
{
    public interface IUserService
    {
        
        Task<List<User>> GetAllUsers();
        Task<User?> GetUserById(int id);

        Task<User> CreateUser(User userModel);

        Task<User?> UpdateUser(int id, UpdateUserRequestDto userDto);

        Task<User?> DeleteUser(int id);
        
    } 
}