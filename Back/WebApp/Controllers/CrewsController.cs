using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DTOs;
using WebApp.Models;
using WebApp.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CrewsController : ControllerBase
    {
        private readonly DataDBContext data;
        private readonly AuthenticationDBContext auth;
        private UserManager<User> manager;
        public CrewsController(UserManager<User> u, DataDBContext d, AuthenticationDBContext a)
        {
            data = d;
            auth = a;
            manager = u;
        }

        // GET: api/<CrewsController>
        [HttpGet]
        public IActionResult Get()
        {
            List<CrewDTO> list = new List<CrewDTO>();
            foreach (Crew c in data.Crews)
            {
                list.Add(new CrewDTO() { Id = c.Id, Name = c.Name });
            }
            return Ok(new { list });
        }

        [HttpGet]
        [Route("GetFreeCrewmates")]
        public IActionResult GetFreeCrewmates()
        {
            List<UserDTO> list = new List<UserDTO>();
            foreach (User u in auth.Users)
            {
                if (u.Role == "Crew Member" && u.CrewID == -1)
                {
                    list.Add(new UserDTO() { FullName = u.FullName, Username = u.UserName });
                }
            }
            return Ok(new { list });
        }

        [HttpGet]
        [Route("GetCrewmates/{id}")]
        public IActionResult GetCrewmates(int id)
        {
            List<UserDTO> list = new List<UserDTO>();
            foreach (User u in auth.Users)
            {
                if (u.CrewID == id)
                {
                    list.Add(new UserDTO() { Username = u.UserName, FullName = u.FullName });
                }
            }
            return Ok(new { list });
        }

        // GET api/<CrewsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CrewsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CrewsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CrewsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
