using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controller;

[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase // Here we are using primary constructor 
{
    //private readonly DataContext _context = context; // Private field

    // Create a GET method that return all the records 

    [HttpGet]

    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await context.Users.ToListAsync();
        return Ok(users);
    }

    [HttpGet("{id:int}")]

    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await context.Users.FindAsync(id);
        if (user == null) return NotFound();
        return Ok(user);
    }

}