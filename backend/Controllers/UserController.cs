using backend.Data;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.mappers;
using backend.Dtos.user;
using Microsoft.EntityFrameworkCore;
using backend.Interfaces.UserInterfaces;
using backend.Repository;
namespace backend.Controllers{

[Route("v1/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    private readonly IuserRepository _userRepository;
    public UserController(ApplicationDBContext context, IuserRepository userRepository)
    {
        _context=context;
        _userRepository= userRepository;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users= await _userRepository.GetAllUsersAsync();

        var userDto= users.Select(u=>u.ToUserDto());

        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserById([FromRoute] int id)
    {
        var user= await _userRepository.GetUserByIdAsync(id);

        if (user == null)
        {
            return NotFound();
        }
        return Ok(user.ToUserDto());
    }
    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestDto userDto)
    {
        var userModel=userDto.ToUserFromCreateDTO();
        await _userRepository.CreateUserAsync(userModel);
        return CreatedAtAction(nameof(GetUserById),new {id=userModel.Id}, userModel.ToUserDto());
    }
    [HttpPut]
    [Route("id")]
    public async Task<IActionResult> UpdateUser([FromRoute] int id, [FromBody] UpdateUserRequestDto updateUserDto)
    {
        var userModel= await _userRepository.UpdateUserAsync(id,updateUserDto);
        if (userModel == null)
        {
            return NotFound();
        }
        return Ok(userModel.ToUserDto());
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteUser([FromRoute] int id)
    {
        var userModel= await _userRepository.DeleteUserAsync(id);

        if (userModel == null)
        {
            return NotFound();
        }

        return NoContent();

    }

}
}