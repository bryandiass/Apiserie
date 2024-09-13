using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Apiserie.Data;
using Apiserie.Models;

namespace Apiserie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class seriesController : ControllerBase
    {
        private readonly DBserieContext _context;

        public seriesController(DBserieContext context)
        {
            _context = context;
        }

        // GET: api/series
        [HttpGet]
        public async Task<ActionResult<IEnumerable<serie>>> Getserie()
        {
          if (_context.serie == null)
          {
              return NotFound();
          }
            return await _context.serie.ToListAsync();
        }

        // GET: api/series/5
        [HttpGet("{id}")]
        public async Task<ActionResult<serie>> Getserie(int id)
        {
          if (_context.serie == null)
          {
              return NotFound();
          }
            var serie = await _context.serie.FindAsync(id);

            if (serie == null)
            {
                return NotFound();
            }

            return serie;
        }

        // PUT: api/series/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putserie(int id, serie serie)
        {
            if (id != serie.Id)
            {
                return BadRequest();
            }

            _context.Entry(serie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!serieExists(id))
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

        // POST: api/series
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<serie>> Postserie(serie serie)
        {
          if (_context.serie == null)
          {
              return Problem("Entity set 'DBserieContext.serie'  is null.");
          }
            _context.serie.Add(serie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getserie", new { id = serie.Id }, serie);
        }

        // DELETE: api/series/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteserie(int id)
        {
            if (_context.serie == null)
            {
                return NotFound();
            }
            var serie = await _context.serie.FindAsync(id);
            if (serie == null)
            {
                return NotFound();
            }

            _context.serie.Remove(serie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool serieExists(int id)
        {
            return (_context.serie?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
