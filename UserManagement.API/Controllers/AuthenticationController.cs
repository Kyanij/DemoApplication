using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserManagement.API.Models;
using UserManagement.API.Models.Authentication.Login;
using UserManagement.API.Models.Authentication.Signup;

namespace UserManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public AuthenticationController(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult> Register([FromBody] RegisterUser registerUser, string role)
        {
            //Check user exists
            var userExists = await _userManager.FindByEmailAsync(registerUser.Email);
            if (userExists != null)
            {
                return StatusCode(StatusCodes.Status403Forbidden,
                    new Response { Status = "Error", Message = "User already exists" });
                    
            }

            //Add user in the database

            IdentityUser user = new()
            {
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerUser.Username
            };

            if(await _roleManager.RoleExistsAsync(role))
            {
                var result = await _userManager.CreateAsync(user, registerUser.Password);
                if (!result.Succeeded)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                          new Response { Status = "Error", Message = "Fail to create user" });
                }
                //Assign Role to user
                await _userManager.AddToRoleAsync(user, role);
                return StatusCode(StatusCodes.Status201Created,
                       new Response { Status = "Success", Message = "User created successfully" });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                          new Response { Status = "Error", Message = $"{role} role doesn't exist" });
            }
            
        }

        [Route("login")]
        [HttpPost]
        public async Task<ActionResult> Login([FromBody] Login logInUser)
        {
            //check if username exists
            var user = await _userManager.FindByNameAsync(logInUser.Username);
            if (user != null)
            {
                var passwordVerified = await _userManager.CheckPasswordAsync(user, logInUser.Password);
                if(passwordVerified)
                {
                    return StatusCode(StatusCodes.Status200OK,
                   new Response { Status = "Success", Message = "Log in successfully" });

                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError,
                  new Response { Status = "Error", Message = "Password is incorrect" });
                }

            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                  new Response { Status = "Error", Message = "Username doesn't exists" });
            }


        }
    }
}
