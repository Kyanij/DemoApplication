using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyApplicationDbContext context;

        public UserController(MyApplicationDbContext context) //Dependency Injection
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult> RegisterUser([FromBody] RegisterUser user)
        {
            this.context.User.Add(user);
            this.context.SaveChangesAsync();
            return CreatedAtAction("GetUser", user);
        }



    }
}
