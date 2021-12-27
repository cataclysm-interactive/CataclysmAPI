using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CataclysmAPI.Models;

namespace CataclysmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactionsController : ControllerBase
    {
        private readonly CoreDbContext _context;

        public FactionsController(CoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Factions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Faction>>> GetFactions()
        {
            List<Faction> factions = new List<Faction>();
            foreach (Faction faction in _context.Factions)
            {
                faction.FactionMembers = faction.FactionMembers.Trim();
                faction.FactionLandClaim = faction.FactionLandClaim.Trim();
                faction.FactionName = faction.FactionName.Trim();
                faction.FactionLogo = faction.FactionLogo.Trim();
                factions.Add(faction);
            }
            return factions;
        }

        // GET: api/Factions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Faction>> GetFaction(long id)
        {
            var faction = await _context.Factions.FindAsync(id);

            if (faction == null)
            {
                return NotFound();
            }

            faction.FactionMembers = faction.FactionMembers.Trim();
            faction.FactionLandClaim = faction.FactionLandClaim.Trim();
            faction.FactionName = faction.FactionName.Trim();

            return faction;
        }

        // PUT: api/Factions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaction(long id, Faction faction)
        {
            if (id != faction.id)
            {
                return BadRequest();
            }
            var oldFaction = await _context.Factions.FindAsync(id);
            if (oldFaction.FactionMembers != faction.FactionMembers && faction.FactionMembers != null)
                oldFaction.FactionMembers = faction.FactionMembers;

            _context.Entry(oldFaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FactionExists(id))
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

        // POST: api/Factions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostFaction(Faction faction)
        {
            if (FactionExists(faction.id))
            {
                return NoContent();
            }
            else
            {
                _context.Factions.Add(faction);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetFaction", new { id = faction.id }, faction);
            }

        }

        // DELETE: api/Factions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaction(long id)
        {
            var faction = await _context.Factions.FindAsync(id);
            if (faction == null)
            {
                return NotFound();
            }

            _context.Factions.Remove(faction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FactionExists(long id)
        {
            return _context.Factions.Any(e => e.id == id);
        }
    }
}
