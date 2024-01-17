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

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(userService.GetAll());
        }
        
        [HttpPost]
        public IActionResult Add()
        {
            //degistir
            return Created("", new User { Id = 1, Name = "Product 3", Surname="abc", Age = 2 });

        }

        [HttpPut]
        public IActionResult Update()
        {
            return NoContent();
            
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}
