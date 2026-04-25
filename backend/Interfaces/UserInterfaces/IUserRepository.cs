
using backend.Dtos.user;
using backend.Models;

namespace backend.Interfaces.UserInterfaces
{
    public interface IuserRepository
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(int id);

        Task<User> CreateUserAsync(User userModel);

        Task<User?> UpdateUserAsync(int id, UpdateUserRequestDto userDto);

        Task<User?> DeleteUserAsync(User userModel);
    }
}