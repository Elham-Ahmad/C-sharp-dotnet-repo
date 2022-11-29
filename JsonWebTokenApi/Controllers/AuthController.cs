using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Security.Cryptography;

namespace JsonWebTokenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //User object to store username,passwordhash and passwordSalt
        public static User user = new User();

        // Register User api
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            user.Username = request.Username;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            return Ok(user);

        }

        //method to verify username and password 
        [HttpPost("Login")]
        public async Task<ActionResult<string>>Login (UserDto request)
        {
            if (user.Username != request.Username)
            {
                return BadRequest("user not found!");

            }
            if (!VerifyPasswordHash(request.Password,user.PasswordHash,user.PasswordSalt))
            {
                return BadRequest("wrong password");
            }
            string token = CreateToken(user);
            return Ok("my crazy token");
        }

        private string CreateToken (User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.Username)

            };
            var key = new SymmetricSecurityKey ()

            return string.Empty;
        }

        //Creating passwordHash method which is using cryptography algorithm (HMAC)
        //to generate passwordsalt and passwordhash and will store that in user object
        private void CreatePasswordHash(string password ,out byte[] passwordHash,out byte[] passwordSalt)
        {

            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key; //create a key 
                
                //generate a hash from the password
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        //method to verify password 

        private bool VerifyPasswordHash(string password, byte [] passwordHash, byte[] passwordSalt)
        {
            using (var hmac  = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

    }
}
