using backend.Data;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.mappers;
using backend.Dtos.user;
using Microsoft.EntityFrameworkCore;
namespace backend.Controllers;

[Route("v1/users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly ApplicationDBContext _context;
    public UserController(ApplicationDBContext context)
    {
        _context=context;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users= await  _context.Users.ToListAsync();

        var userDto= users.Select(u=>u.ToUserDto());

        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserById([FromRoute] int id)
    {
        var user= await _context.Users.FindAsync(id);

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
        await _context.Users.AddAsync(userModel);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetUserById),new {id=userModel.Id}, userModel.ToUserDto());
    }
   /* [HttpPut]
    [Route("id")]
    public async Task<IActionResult> UpdateUser([FromRoute] int id, [FromBody] UpdateUserRequestDto updateUserDto)
    {
        var userModel= await _context.Users.FirstOrDefaultAsync(x=> x.Id ==id);
        if (userModel == null)
        {
            return NotFound();
        }
        
    }*/

    [HttpDelete]
    [Route("{id}")]
    public async  Task<IActionResult> DeleteUser([FromRoute] int id)
    {
        var userModel= await _context.Users.FirstOrDefaultAsync(x=> x.Id==id);

        if (userModel == null)
        {
            return NotFound();
        }
        _context.Users.Remove(userModel);

        await _context.SaveChangesAsync();

        return NoContent();

    }

}
