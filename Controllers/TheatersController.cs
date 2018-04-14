using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment2_Part2.Models;

namespace Assignment2_Part2.Controllers
{
    [Produces("application/json")]
    [Route("api/Theaters")]
    public class TheatersController : Controller
    {
        private readonly ProjectModels _context;

        public TheatersController(ProjectModels context)
        {
            _context = context;
        }

        // GET: api/Theaters
        [HttpGet]
        public IEnumerable<Theaters> GetTheater()
        {
            return _context.Theater;
        }

        // GET: api/Theaters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTheaters([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var theaters = await _context.Theater.SingleOrDefaultAsync(m => m.Theater_id == id);

            if (theaters == null)
            {
                return NotFound();
            }

            return Ok(theaters);
        }

        // PUT: api/Theaters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheaters([FromRoute] int id, [FromBody] Theaters theaters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != theaters.Theater_id)
            {
                return BadRequest();
            }

            _context.Entry(theaters).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TheatersExists(id))
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

        // POST: api/Theaters
        [HttpPost]
        public async Task<IActionResult> PostTheaters([FromBody] Theaters theaters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Theater.Add(theaters);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTheaters", new { id = theaters.Theater_id }, theaters);
        }

        // DELETE: api/Theaters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTheaters([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var theaters = await _context.Theater.SingleOrDefaultAsync(m => m.Theater_id == id);
            if (theaters == null)
            {
                return NotFound();
            }

            _context.Theater.Remove(theaters);
            await _context.SaveChangesAsync();

            return Ok(theaters);
        }

        private bool TheatersExists(int id)
        {
            return _context.Theater.Any(e => e.Theater_id == id);
        }
    }
}