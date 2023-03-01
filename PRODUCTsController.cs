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
    public class PRODUCTsController : ControllerBase
    {
        

        private readonly Context _context = new Context();

        // GET: api/PRODUCTs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PRODUCT>>> GetPRODUCT()
        {
            return await _context.PRODUCT.ToListAsync();
        }

        // GET: api/PRODUCTs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PRODUCT>> GetPRODUCT(int id)
        {
            var pRODUCT = await _context.PRODUCT.FindAsync(id);

            if (pRODUCT == null)
            {
                return NotFound();
            }

            return pRODUCT;
        }

        // PUT: api/PRODUCTs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPRODUCT(int id, PRODUCT pRODUCT)
        {
            if (id != pRODUCT.ProductID)
            {
                return BadRequest();
            }

            _context.Entry(pRODUCT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PRODUCTExists(id))
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

        // POST: api/PRODUCTs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PRODUCT>> PostPRODUCT(PRODUCT pRODUCT)
        {
            _context.PRODUCT.Add(pRODUCT);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPRODUCT", new { id = pRODUCT.ProductID }, pRODUCT);
        }

        // DELETE: api/PRODUCTs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePRODUCT(int id)
        {
            var pRODUCT = await _context.PRODUCT.FindAsync(id);
            if (pRODUCT == null)
            {
                return NotFound();
            }

            _context.PRODUCT.Remove(pRODUCT);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PRODUCTExists(int id)
        {
            return _context.PRODUCT.Any(e => e.ProductID == id);
        }
    }
}
