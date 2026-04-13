using backend.Data;
using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.mappers;
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

}
