using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
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

        // GET: api/Crews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crew>>> GetCrews()
        {
            return await data.Crews.ToListAsync();
        }

        // GET: api/Crews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Crew>> GetCrew(int id)
        {
            var crew = await data.Crews.FindAsync(id);

            if (crew == null)
            {
                return NotFound();
            }

            return crew;
        }

        // PUT: api/Crews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCrew(int id, Crew crew)
        {
            if (id != crew.Id)
            {
                return BadRequest();
            }

            //data.Entry(crew).State = EntityState.Modified;

            try
            {
                await data.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CrewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Crews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Crew>> PostCrew(Crew crew)
        {
            data.Crews.Add(crew);
            await data.SaveChangesAsync();

            return CreatedAtAction("GetCrew", new { id = crew.Id }, crew);
        }

        // DELETE: api/Crews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCrew(int id)
        {
            var crew = await data.Crews.FindAsync(id);
            if (crew == null)
            {
                return NotFound();
            }

            data.Crews.Remove(crew);
            await data.SaveChangesAsync();

            return NoContent();
        }

        private bool CrewExists(int id)
        {
            return data.Crews.Any(e => e.Id == id);
        }
    }
}
