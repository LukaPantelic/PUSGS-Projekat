using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class StreetsController : ControllerBase
    {
        private readonly DataDBContext data;
        private readonly AuthenticationDBContext auth;
        private UserManager<User> manager;
        public StreetsController(UserManager<User> u, DataDBContext d, AuthenticationDBContext a)
        {
            data = d;
            auth = a;
            manager = u;
        }

        // GET: api/Streets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Street>>> GetStreets()
        {
            return await data.Streets.ToListAsync();
        }

        // GET: api/Streets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Street>> GetStreet(int id)
        {
            var street = await data.Streets.FindAsync(id);

            if (street == null)
            {
                return NotFound();
            }

            return street;
        }

        // PUT: api/Streets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStreet(int id, Street street)
        {
            if (id != street.Id)
            {
                return BadRequest();
            }

            data.Entry(street).State = EntityState.Modified;

            try
            {
                await data.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StreetExists(id))
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

        // POST: api/Streets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Street>> PostStreet(Street street)
        {
            data.Streets.Add(street);
            await data.SaveChangesAsync();

            return CreatedAtAction("GetStreet", new { id = street.Id }, street);
        }

        // DELETE: api/Streets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStreet(int id)
        {
            var street = await data.Streets.FindAsync(id);
            if (street == null)
            {
                return NotFound();
            }

            data.Streets.Remove(street);
            await data.SaveChangesAsync();

            return NoContent();
        }

        private bool StreetExists(int id)
        {
            return data.Streets.Any(e => e.Id == id);
        }
    }
}
