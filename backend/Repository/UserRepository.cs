


using backend.Data;
using backend.Dtos.userDtos;
using backend.Interfaces.UserInterfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class UserRepository : IuserRepository
    {   
        private readonly ApplicationDBContext _context;
        public UserRepository(ApplicationDBContext context)
        {
            _context= context;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Users.Include(x=>x.medicationSchedules).ToListAsync();
        }
        public async Task<User?> GetUserByIdAsync(int id)
        {
           return await _context.Users.Include(x=>x.medicationSchedules).FirstOrDefaultAsync(ms=>ms.Id==id);

        }

        public async Task<User?> UpdateUserAsync(int id, UpdateUserRequestDto updateUserDto)
        {

            //I should move this logic to the service
           var userExists= await _context.Users.FirstOrDefaultAsync(x=> x.Id==id);
           //We use FirstOrDefault because it returns null if not found
           if (userExists == null)
            {
                return null;
            }
            userExists.FirstName=updateUserDto.FirstName;
            userExists.LastName=updateUserDto.LastName;
            userExists.DateOfBirth=updateUserDto.DateOfBirth;
            userExists.Email=updateUserDto.Email;
            userExists.Gender=updateUserDto.Gender;
            userExists.Password=updateUserDto.Password;
            await _context.SaveChangesAsync();
            return userExists;
        }
          public async Task<User> CreateUserAsync(User userModel)
        {
            await _context.Users.AddAsync(userModel);
            await _context.SaveChangesAsync();
            return userModel;
        }

        public async Task<User?> DeleteUserAsync(User userModel)
        {
            _context.Users.Remove(userModel);
            await _context.SaveChangesAsync();
            return userModel;
        }
    }
}