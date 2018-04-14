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
    [Route("api/Screens")]
    public class ScreensController : Controller
    {
        private readonly ProjectModels _context;

        public ScreensController(ProjectModels context)
        {
            _context = context;
        }

        // GET: api/Screens
        [HttpGet]
        public IEnumerable<Screens> GetScreen()
        {
            return _context.Screen;
        }

        // GET: api/Screens/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetScreens([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var screens = await _context.Screen.SingleOrDefaultAsync(m => m.Screen_id == id);

            if (screens == null)
            {
                return NotFound();
            }

            return Ok(screens);
        }

        // PUT: api/Screens/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScreens([FromRoute] string id, [FromBody] Screens screens)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != screens.Screen_id)
            {
                return BadRequest();
            }

            _context.Entry(screens).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScreensExists(id))
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

        // POST: api/Screens
        [HttpPost]
        public async Task<IActionResult> PostScreens([FromBody] Screens screens)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Screen.Add(screens);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScreens", new { id = screens.Screen_id }, screens);
        }

        // DELETE: api/Screens/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScreens([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var screens = await _context.Screen.SingleOrDefaultAsync(m => m.Screen_id == id);
            if (screens == null)
            {
                return NotFound();
            }

            _context.Screen.Remove(screens);
            await _context.SaveChangesAsync();

            return Ok(screens);
        }

        private bool ScreensExists(string id)
        {
            return _context.Screen.Any(e => e.Screen_id == id);
        }
    }
}