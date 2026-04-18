using backend.Data;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.mappers;
using backend.Dtos.user;
using Microsoft.EntityFrameworkCore;
using backend.Interfaces.UserInterfaces;
using backend.Repository;
using backend.Services.UserService;
namespace backend.Controllers{

[Route("v1/users")]
[ApiController]
public class UserController : ControllerBase
{
   

    private readonly IUserService _userService;
    
    public UserController(IUserService userService)
    {
        _userService=userService;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users= await _userService.GetAllUsers();

        var userDto= users.Select(u=>u.ToUserDto());

        return Ok(userDto);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserById([FromRoute] int id)
    {
        var user= await _userService.GetUserById(id);

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
        await _userService.CreateUser(userModel);
        return CreatedAtAction(nameof(GetUserById),new {id=userModel.Id}, userModel.ToUserDto());
    }
    [HttpPut]
    [Route("id")]
    public async Task<IActionResult> UpdateUser([FromRoute] int id, [FromBody] UpdateUserRequestDto updateUserDto)
    {
        var userModel= await _userService.UpdateUser(id,updateUserDto);
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
        var userModel= await _userService.DeleteUser(id);

        if (userModel == null)
        {
            return NotFound();
        }

        return NoContent();

    }

}
}