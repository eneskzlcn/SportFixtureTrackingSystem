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
    public class SportsController : Controller
    {
        private readonly SportFixturePointContext _context;

        public SportsController(SportFixturePointContext context)
        {
            _context = context;
        }

        // GET: Sports
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sports.ToListAsync());
        }

        // GET: Sports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sport = await _context.Sports
                .FirstOrDefaultAsync(m => m.SportId == id);
            if (sport == null)
            {
                return NotFound();
            }

            return View(sport);
        }

        // GET: Sports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SportId,SportName,SportDescription,RequiredTeamPlayerCount")] Sport sport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sport);
        }

        // GET: Sports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sport = await _context.Sports.FindAsync(id);
            if (sport == null)
            {
                return NotFound();
            }
            return View(sport);
        }

        // POST: Sports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SportId,SportName,SportDescription,RequiredTeamPlayerCount")] Sport sport)
        {
            if (id != sport.SportId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SportExists(sport.SportId))
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
            return View(sport);
        }

        // GET: Sports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sport = await _context.Sports
                .FirstOrDefaultAsync(m => m.SportId == id);
            if (sport == null)
            {
                return NotFound();
            }

            return View(sport);
        }

        // POST: Sports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sport = await _context.Sports.FindAsync(id);
            AlsoDeleteTeams(id);
            _context.Sports.Remove(sport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private void AlsoDeleteTeams(int id)
        {
            var teams =  _context.Teams.Where(r => r.SportId == id).ToList();
            AlsoDeleteFixtures(teams);
            _context.RemoveRange(teams);
        }
        private void AlsoDeleteFixtures(List<Team> teams)
        {
            var fixtures = _context.Fixtures.Include(f => f.HomeTeam).Include(f => f.AwayTeam).Where(a => teams.Contains(a.HomeTeam) || teams.Contains(a.AwayTeam)).ToList();
            AlsoDeleteResults(fixtures);
            _context.RemoveRange(fixtures);
        }
        private void AlsoDeleteResults(List<Fixture> fixtures)
        {
            var results = _context.FixtureResults.Include(f => f.Fixture).Where(f => fixtures.Contains(f.Fixture)).ToList();
            _context.RemoveRange(results);
        }
        private bool SportExists(int id)
        {
            return _context.Sports.Any(e => e.SportId == id);
        }
    }
}
