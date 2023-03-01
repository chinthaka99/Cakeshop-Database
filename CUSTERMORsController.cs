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
    public class CUSTERMORsController : ControllerBase
    {
 

        private readonly Context _context = new Context();

        // GET: api/CUSTERMORs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CUSTERMOR>>> GetCUSTERMOR()
        {
            return await _context.CUSTERMOR.ToListAsync();
        }

        // GET: api/CUSTERMORs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CUSTERMOR>> GetCUSTERMOR(int id)
        {
            var cUSTERMOR = await _context.CUSTERMOR.FindAsync(id);

            if (cUSTERMOR == null)
            {
                return NotFound();
            }

            return cUSTERMOR;
        }

        // PUT: api/CUSTERMORs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCUSTERMOR(int id, CUSTERMOR cUSTERMOR)
        {
            if (id != cUSTERMOR.CustermorID)
            {
                return BadRequest();
            }

            _context.Entry(cUSTERMOR).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CUSTERMORExists(id))
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

        // POST: api/CUSTERMORs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CUSTERMOR>> PostCUSTERMOR(CUSTERMOR cUSTERMOR)
        {
            _context.CUSTERMOR.Add(cUSTERMOR);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCUSTERMOR", new { id = cUSTERMOR.CustermorID }, cUSTERMOR);
        }

        // DELETE: api/CUSTERMORs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCUSTERMOR(int id)
        {
            var cUSTERMOR = await _context.CUSTERMOR.FindAsync(id);
            if (cUSTERMOR == null)
            {
                return NotFound();
            }

            _context.CUSTERMOR.Remove(cUSTERMOR);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CUSTERMORExists(int id)
        {
            return _context.CUSTERMOR.Any(e => e.CustermorID == id);
        }
    }
}
