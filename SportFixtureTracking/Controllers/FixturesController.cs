using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportFixtureTracking.Models;

namespace SportFixtureTracking.Controllers
{
    public class FixturesController : Controller
    {
        private readonly SportFixturePointContext _context;

        public FixturesController(SportFixturePointContext context)
        {
            _context = context;
        }

        // GET: Fixtures
        public async Task<IActionResult> Index()
        {
            
            var sportFixturePointContext = _context.Fixtures.Include(f => f.AwayTeam).Include(f => f.HomeTeam).Include(r=>r.FixtureResults);
            return View(await sportFixturePointContext.ToListAsync());
        }
  
        // GET: Fixtures/Create
        public IActionResult Create()
        {
            ViewData["AwayTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName");
            ViewData["HomeTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName");
            return View();
        }

        // POST: Fixtures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       
        public async Task<IActionResult> Create([Bind("FixtureId,FixtureDate,HomeTeamId,AwayTeamId,FixtureHome")] Fixture fixture)
        {
            var homeTeam = _context.Teams.Where(r=>  r.TeamId == fixture.HomeTeamId).FirstOrDefault();
            var awayTeam = _context.Teams.Where(r => r.TeamId == fixture.AwayTeamId).FirstOrDefault();
            if(homeTeam.SportId != awayTeam.SportId)
            {
                return NotFound();
            }
            fixture.IsFinished = "N";
            if (ModelState.IsValid)
            {
                _context.Add(fixture);
               
                await _context.SaveChangesAsync();
                return AlsoAddFixtureResult(fixture);
                //return RedirectToAction(nameof(Index));
            }
            
            ViewData["AwayTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixture.AwayTeamId);
            ViewData["HomeTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixture.HomeTeamId);
            return View(fixture);
        }

        public IActionResult AlsoAddFixtureResult(Fixture fixture)
        {
            FixtureResult f = new FixtureResult { ResultId = 0, Fixture_Id = fixture.FixtureId, AwayTeamScore = 0, HomeTeamScore = 0 };
            if(ModelState.IsValid)
            {
                _context.Add(f);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        
        // GET: Fixtures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixture = await _context.Fixtures.Include(r => r.AwayTeam).Include(s => s.HomeTeam).FirstOrDefaultAsync(a => a.FixtureId == id);
            if (fixture == null)
            {
                return NotFound();
            }
            ViewData["AwayTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixture.AwayTeamId);
            ViewData["HomeTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixture.HomeTeamId);
            return View(fixture);
        }

        // POST: Fixtures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FixtureId,FixtureDate,HomeTeamId,AwayTeamId,FixtureHome,IsFinished")] Fixture fixture)
        {
            if (id != fixture.FixtureId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fixture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FixtureExists(fixture.FixtureId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["AwayTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixture.AwayTeamId);
            ViewData["HomeTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixture.HomeTeamId);
            return View(fixture);
        }

        // GET: Fixtures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixture = await _context.Fixtures
                .Include(f => f.AwayTeam)
                .Include(f => f.HomeTeam)
                .FirstOrDefaultAsync(m => m.FixtureId == id);
            if (fixture == null)
            {
                return NotFound();
            }

            return View(fixture);
        }

        // POST: Fixtures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            
            var fixture = await _context.Fixtures.FindAsync(id);
            DeleteFixtureResultByFixtureId(fixture.FixtureId);
            _context.Fixtures.Remove(fixture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private void DeleteFixtureResultByFixtureId(int id)
        {
            var result = _context.FixtureResults.FirstOrDefault(r=> r.Fixture_Id == id);
            _context.FixtureResults.Remove(result);
        }
        private bool FixtureExists(int id)
        {
            return _context.Fixtures.Any(e => e.FixtureId == id);
        }
    }
}
