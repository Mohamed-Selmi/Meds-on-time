using backend.Dtos.userDtos;
using backend.Models;
using backend.Interfaces.UserInterfaces;
using backend.Data;
using backend.mappers;
using Microsoft.EntityFrameworkCore;
namespace backend.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IuserRepository _userRepository;
        private readonly ApplicationDBContext _context;

         public UserService(ApplicationDBContext context, IuserRepository userRepository)
         {
            _context=context;
            _userRepository=userRepository;
         }

        public async Task<User> CreateUser(User userModel)
        {
            return await _userRepository.CreateUserAsync(userModel);
            
        }

        public async Task<User?> DeleteUser(int id)
        {
            var userModel= await _context.Users.FirstOrDefaultAsync(x=> x.Id==id);
            if (userModel == null)
            {
                return null;
            }
            return await _userRepository.DeleteUserAsync(userModel);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<User?> UpdateUser(int id, UpdateUserRequestDto userDto)
        {
            return await _userRepository.UpdateUserAsync(id,userDto);
        }
    }

}