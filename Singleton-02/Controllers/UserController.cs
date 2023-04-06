using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Singleton_02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        // create a private static instance of the User class
        private readonly User _user;
        
        // create a constructor that will initialize the _user instance
        public UserController(ILogger<UserController> logger, User user)
        {
            _user = user;
        }

        // create a endpoint that will return an Ok status
        [HttpPost]
        public IActionResult Get()
        {
            return Ok(_user.Name);
        }
    }
}