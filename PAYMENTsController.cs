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
    public class PAYMENTsController : ControllerBase
    {
        

        private readonly Context _context = new Context();

        // GET: api/PAYMENTs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PAYMENT>>> GetPAYMENT()
        {
            return await _context.PAYMENT.ToListAsync();
        }

        // GET: api/PAYMENTs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PAYMENT>> GetPAYMENT(int id)
        {
            var pAYMENT = await _context.PAYMENT.FindAsync(id);

            if (pAYMENT == null)
            {
                return NotFound();
            }

            return pAYMENT;
        }

        // PUT: api/PAYMENTs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPAYMENT(int id, PAYMENT pAYMENT)
        {
            if (id != pAYMENT.PaymentID)
            {
                return BadRequest();
            }

            _context.Entry(pAYMENT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PAYMENTExists(id))
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

        // POST: api/PAYMENTs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PAYMENT>> PostPAYMENT(PAYMENT pAYMENT)
        {
            _context.PAYMENT.Add(pAYMENT);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPAYMENT", new { id = pAYMENT.PaymentID }, pAYMENT);
        }

        // DELETE: api/PAYMENTs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePAYMENT(int id)
        {
            var pAYMENT = await _context.PAYMENT.FindAsync(id);
            if (pAYMENT == null)
            {
                return NotFound();
            }

            _context.PAYMENT.Remove(pAYMENT);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PAYMENTExists(int id)
        {
            return _context.PAYMENT.Any(e => e.PaymentID == id);
        }
    }
}
