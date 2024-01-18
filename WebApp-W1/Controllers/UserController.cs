using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp_W1.Models;
using WebApp_W1.Services;

namespace WebApp_W1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService userService = new UserService(new UserRepository());

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(userService.GetAll());
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var user = userService.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        
        [HttpPost("Add")]
        public IActionResult Add()
        {
            return Created("", new User { Id = 1, Name = "Aylin", Surname = "Kara", Age = 25 });
        }

        [HttpPut("Update")]
        public IActionResult Update()
        {
            return NoContent();
            
        }

        [HttpDelete("Delete")]
        public IActionResult Delete()
        {
            return NoContent();
        }


    }
}
