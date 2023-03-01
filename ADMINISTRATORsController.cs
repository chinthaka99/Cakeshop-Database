using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cakeshop.Models;

namespace cakeshop
{
    [Route("api/[controller]")]
    [ApiController]
    public class ADMINISTRATORsController : ControllerBase
    {
        private readonly Context _context = new Context();

        // GET: api/ADMINISTRATORs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ADMINISTRATOR>>> GetADMINISTRATOR()
        {
            return await _context.ADMINISTRATOR.ToListAsync();
        }

        // GET: api/ADMINISTRATORs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ADMINISTRATOR>> GetADMINISTRATOR(int id)
        {
            var aDMINISTRATOR = await _context.ADMINISTRATOR.FindAsync(id);

            if (aDMINISTRATOR == null)
            {
                return NotFound();
            }

            return aDMINISTRATOR;
        }

        // PUT: api/ADMINISTRATORs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutADMINISTRATOR(int id, ADMINISTRATOR aDMINISTRATOR)
        {
            if (id != aDMINISTRATOR.AdministratorID)
            {
                return BadRequest();
            }

            _context.Entry(aDMINISTRATOR).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ADMINISTRATORExists(id))
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

        // POST: api/ADMINISTRATORs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ADMINISTRATOR>> PostADMINISTRATOR(ADMINISTRATOR aDMINISTRATOR)
        {
            _context.ADMINISTRATOR.Add(aDMINISTRATOR);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetADMINISTRATOR", new { id = aDMINISTRATOR.AdministratorID }, aDMINISTRATOR);
        }

        // DELETE: api/ADMINISTRATORs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteADMINISTRATOR(int id)
        {
            var aDMINISTRATOR = await _context.ADMINISTRATOR.FindAsync(id);
            if (aDMINISTRATOR == null)
            {
                return NotFound();
            }

            _context.ADMINISTRATOR.Remove(aDMINISTRATOR);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ADMINISTRATORExists(int id)
        {
            return _context.ADMINISTRATOR.Any(e => e.AdministratorID == id);
        }
    }
}
