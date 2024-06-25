using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Walky.API.Models.DTO;
using Walky.API.Repositories.IRepository;

namespace Walky.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly ITokenRepository _tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager,ITokenRepository tokenRepository)
        {
            this._userManager = userManager;
            this._tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerDto.Username,
                Email = registerDto.Email
            };

            var result = await _userManager.CreateAsync(identityUser, registerDto.Password);

            if (result.Succeeded)
            {
                if (registerDto.Roles != null)
                {
                    result = await _userManager.AddToRolesAsync(identityUser, registerDto.Roles);
                    if (result.Succeeded)
                    {
                        return Ok("User is registered! Please log in.");
                    }
                } 
      
            }

            return BadRequest("Something went wrong!");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var user = await _userManager.FindByEmailAsync(loginDto.Email);

            if(user != null)
            {
                var passwordResult = await _userManager.CheckPasswordAsync(user,loginDto.Password);

                if (passwordResult)
                {
                    var roles = await _userManager.GetRolesAsync(user);

                    if (roles != null)
                    {
                        var  jwt = _tokenRepository.CreateJWTToken(user,roles.ToList());
                        return Ok(jwt);
                    }

                }
            }

            return BadRequest("Email or password incorrect");

        }



    }
}
