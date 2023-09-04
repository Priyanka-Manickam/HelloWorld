using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CRUDApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        //private readonly UserManager<ApplicationUser> userManager;
        // private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;
        private Stopwatch timer = new Stopwatch();

        public AuthenticateController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        //public string GetToken()
        //{
        //    string token = string.Empty;
        //    var claims = new[]
        //    {
        //        new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
        //        new Claim(JwtRegisteredClaimNames.Iat, Guid.NewGuid().ToString())
        //    };

        //    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
        //    var signin = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //    var createToken = new JwtSecurityToken(
        //        configuration["Jwt:Issuer"],
        //        configuration["Jwt:Audience"],
        //        claims,
        //        expires: DateTime.UtcNow.AddDays(1),
        //        signingCredentials: signin
        //        );

        //    token = new JwtSecurityTokenHandler().WriteToken(createToken);

        //    return token;
        //}

        [HttpGet(Name = "TestAsync")]
        public async Task AsyncTestMethod()
        {
            timer.Start();
            Console.WriteLine(timer.Elapsed.ToString());
            Task task1 = PrintData();
            Task task2 = PrintDataAsync();

            //await task1;
            //await task2;

            //await Task.WhenAll(task1, task2);
            Console.WriteLine(timer.Elapsed.ToString());
        }

        [NonAction]
        public async Task PrintData()
        {
            await Task.Delay(3000);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("PrintData" + i.ToString());
            }

            Console.WriteLine("PrintData Completed" + timer.Elapsed.TotalSeconds.ToString());
        }
        [NonAction]
        public async Task PrintDataAsync()
        {
            //await Task.Delay(3000);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("PrintDataAsync" + i.ToString());
            }
            Console.WriteLine("PrintDataAsync Completed"  + timer.Elapsed.TotalSeconds.ToString());
        }
    }
}
