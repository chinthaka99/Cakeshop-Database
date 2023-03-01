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
    public class CATEGORiesController : ControllerBase
    {
        private readonly Context _context = new Context();

        // GET: api/CATEGORies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CATEGORY>>> GetCATEGORY()
        {
            return await _context.CATEGORY.ToListAsync();
        }

        // GET: api/CATEGORies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CATEGORY>> GetCATEGORY(int id)
        {
            var cATEGORY = await _context.CATEGORY.FindAsync(id);

            if (cATEGORY == null)
            {
                return NotFound();
            }

            return cATEGORY;
        }

        // PUT: api/CATEGORies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCATEGORY(int id, CATEGORY cATEGORY)
        {
            if (id != cATEGORY.CategoryID)
            {
                return BadRequest();
            }

            _context.Entry(cATEGORY).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CATEGORYExists(id))
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

        // POST: api/CATEGORies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CATEGORY>> PostCATEGORY(CATEGORY cATEGORY)
        {
            _context.CATEGORY.Add(cATEGORY);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCATEGORY", new { id = cATEGORY.CategoryID }, cATEGORY);
        }

        // DELETE: api/CATEGORies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCATEGORY(int id)
        {
            var cATEGORY = await _context.CATEGORY.FindAsync(id);
            if (cATEGORY == null)
            {
                return NotFound();
            }

            _context.CATEGORY.Remove(cATEGORY);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CATEGORYExists(int id)
        {
            return _context.CATEGORY.Any(e => e.CategoryID == id);
        }
    }
}
