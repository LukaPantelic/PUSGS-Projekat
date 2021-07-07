using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApp.Models;
using WebApp.Repository;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallsController : ControllerBase
    {
        private readonly DataDBContext data;
        private readonly AuthenticationDBContext auth;
        private UserManager<User> _userManager;
        private ApplicationSettings _appSettings;

        public CallsController(UserManager<User> userManager, IOptions<ApplicationSettings> appSettings, DataDBContext d, AuthenticationDBContext a)
        {
            _userManager = userManager;
            _appSettings = appSettings.Value;
            data = d;
            auth = a;
        }

        // GET: api/Calls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Call>>> GetCalls()
        {
            return await data.Calls.ToListAsync();
        }

        // GET: api/Calls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Call>> GetCall(int id)
        {
            var call = await data.Calls.FindAsync(id);

            if (call == null)
            {
                return NotFound();
            }

            return call;
        }

        // PUT: api/Calls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCall(int id, Call call)
        {
            if (id != call.Id)
            {
                return BadRequest();
            }

            data.Entry(call).State = EntityState.Modified;

            try
            {
                await data.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CallExists(id))
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

        // POST: api/Calls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Call>> PostCall(Call call)
        {
            data.Calls.Add(call);
            await data.SaveChangesAsync();

            return CreatedAtAction("GetCall", new { id = call.Id }, call);
        }

        // DELETE: api/Calls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCall(int id)
        {
            var call = await data.Calls.FindAsync(id);
            if (call == null)
            {
                return NotFound();
            }

            data.Calls.Remove(call);
            await data.SaveChangesAsync();

            return NoContent();
        }

        private bool CallExists(int id)
        {
            return data.Calls.Any(e => e.Id == id);
        }
    }
}
