using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: Controller
    {
    private readonly DataContext _context;

    public UsersController(DataContext context) {
      this._context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
      return await _context.Users.ToListAsync();
      
    }

    // api/users/3
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id){
      return await _context.Users.FindAsync(id);
  
    }

    }
}