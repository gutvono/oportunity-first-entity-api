using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using OportunityApi.Data;

namespace OportunityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OportunitiesController : ControllerBase
    {
        private readonly OportunityApiContext _context;

        public OportunitiesController(OportunityApiContext context)
        {
            _context = context;
        }

        // GET: api/Oportunities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oportunity>>> GetOportunity()
        {
            return await _context.Oportunity.ToListAsync();
        }

        // GET: api/Oportunities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Oportunity>> GetOportunity(int id)
        {
            var oportunity = await _context.Oportunity.FindAsync(id);

            if (oportunity == null)
            {
                return NotFound();
            }

            return oportunity;
        }

        // PUT: api/Oportunities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOportunity(int id, Oportunity oportunity)
        {
            if (id != oportunity.Id)
            {
                return BadRequest();
            }

            _context.Entry(oportunity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OportunityExists(id))
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

        // POST: api/Oportunities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Oportunity>> PostOportunity(Oportunity oportunity)
        {
            _context.Oportunity.Add(oportunity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOportunity", new { id = oportunity.Id }, oportunity);
        }

        // DELETE: api/Oportunities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOportunity(int id)
        {
            var oportunity = await _context.Oportunity.FindAsync(id);
            if (oportunity == null)
            {
                return NotFound();
            }

            _context.Oportunity.Remove(oportunity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OportunityExists(int id)
        {
            return _context.Oportunity.Any(e => e.Id == id);
        }
    }
}
