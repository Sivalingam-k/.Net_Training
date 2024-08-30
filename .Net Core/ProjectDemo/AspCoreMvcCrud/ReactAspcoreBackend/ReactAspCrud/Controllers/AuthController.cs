using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ReactAspCrud.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using Microsoft.EntityFrameworkCore;

namespace ReactAspCrud.Controllers
{
    // Controllers/AuthController.cs
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly StudentDbContext _context;

        public AuthController(IConfiguration configuration, StudentDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (await _context.Student1s.AnyAsync(s => s.Username == model.Username))
                return BadRequest("Username already exists");

            var stud = new Student1
            {
                Username = model.Username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password)
            };

            _context.Student1s.Add(stud);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var stud = await _context.Student1s
                .SingleOrDefaultAsync(s => s.Username == model.Username);

            if (stud == null || !BCrypt.Net.BCrypt.Verify(model.Password, stud.PasswordHash))
            {
                return Unauthorized(); // Return 401 Unauthorized if login fails
            }

            var key = _configuration["Jwt:Key"];
            if (string.IsNullOrEmpty(key))
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "JWT key is not configured.");
            }

            var keyBytes = Encoding.ASCII.GetBytes(key);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.Name, stud.Username)
            }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"]
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(new { Token = tokenString });
        }
    }
}


