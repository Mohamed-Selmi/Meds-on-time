using backend.Data;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.mappers;
using backend.Dtos.user;
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
    public ActionResult<List<User>> GetAllUsers()
    {
        var users= _context.Users.ToList()
        .Select(u=>u.ToUserDto());

        return Ok(users);
    }

    [HttpGet("{id}")]
    public ActionResult<User> GetUserById([FromRoute] int id)
    {
        var user= _context.Users.Find(id);

        if (user == null)
        {
            return NotFound();
        }
        return Ok(user.ToUserDto());
    }
    [HttpPost]
    public IActionResult CreateUser([FromBody] CreateUserRequestDto userDto)
    {
        var userModel=userDto.ToUserFromCreateDTO();
        _context.Users.Add(userModel);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetUserById),new {id=userModel.Id}, userModel.ToUserDto());
    }


}
