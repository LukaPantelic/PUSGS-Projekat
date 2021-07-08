using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApp.DTOs;
using WebApp.Models;
using WebApp.Repository;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DataDBContext data;
        private readonly AuthenticationDBContext auth;
        private UserManager<User> _userManager;
        private ApplicationSettings _appSettings;

        public AuthController(UserManager<User> userManager, IOptions<ApplicationSettings> appSettings, DataDBContext d, AuthenticationDBContext a)
        {
            _userManager = userManager;
            _appSettings = appSettings.Value;
            data = d;
            auth = a;
        }


        [HttpPost]
        [Route("Login")]
        // POST: api/<controller>/Login
        public async Task<IActionResult> Login([FromBody] UserLoginDTO login)
        {
            User user = await _userManager.FindByNameAsync(login.Username);
            if (user != null && await _userManager.CheckPasswordAsync(user, login.Password))
            {
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("UserID", user.Id.ToString()),
                        new Claim("Role", user.Role),
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),

                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                };
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(securityToken);
                return Ok(new { token, role = user.Role, name = user.FullName, userId = user.Id.ToString() });
            }
            else
                return BadRequest(new { message = "Username or password is incorrect." });
        }

        // POST: api/<controller>
        [HttpPost]
        [Route("Register")]
        public async Task<Object> Post([FromBody] UserDTO model)
        {
            User applicationUser = new User()
            {
                UserName = model.Username,
                Email = model.Email,
                FullName = model.FullName,
                DOB = model.DOB,
                Role = model.Role,
                CrewID = model.CrewID,
                StreetID = (await data.Streets.FirstOrDefaultAsync(x => x.Name == model.Street)).Id
            };
            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                if (result.Errors.Any())
                {
                    var test = result.Errors.ToList();
                    return BadRequest(new { message = test[0].Description });
                }
                return Ok();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        [Route("GetProfile")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> GetProfile()
        {
            User temp = await _userManager.FindByIdAsync(User.Claims.First(x => x.Type == "UserID").Value);
            UserDTO retval = new UserDTO()
            {
                FullName = temp.FullName,
                Username = temp.UserName,
                Role = temp.Role,
                Email = temp.Email,
                CrewID = temp.CrewID,
                Street = (await data.Streets.FirstOrDefaultAsync(x => x.Id == temp.StreetID)).Name,
                DOB = temp.DOB,

            };
            return Ok(new { retval });
        }

        [HttpPost]
        [Route("EditProfile")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<IActionResult> EditProfile(EditProfileDTO model)
        {
            string id = User.Claims.First(x => x.Type == "UserID").Value;
            User temp = await _userManager.FindByIdAsync(id);
            temp.FullName = model.body.FullName;
            temp.UserName = model.body.Username;
            temp.Role = model.body.Role;
            temp.Email = model.body.Email;
            temp.CrewID = model.body.CrewID;
            temp.StreetID = (await data.Streets.FirstOrDefaultAsync(x => x.Name == model.body.Street)).Id;
            temp.DOB = model.body.DOB;
            await _userManager.UpdateAsync(temp);
            if (!string.IsNullOrWhiteSpace(model.body.Password))
            {
                if ((await _userManager.ChangePasswordAsync(temp, model.currentPassword, model.body.Password)).Succeeded)
                {
                    return Ok(new { msg = "changedpass" });
                }
                else
                {
                    return Ok(new { msg = "error" });
                }
            }
            return Ok(new { msg = "ok" });
        }
    }
}
