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
    public class FixtureResultsController : Controller
    {
        private readonly SportFixturePointContext _context;

        public FixtureResultsController(SportFixturePointContext context)
        {
            _context = context;
        }

        // GET: FixtureResults
        public async Task<IActionResult> Index()
        {
            var sportFixturePointContext = _context.FixtureResults.Include(f => f.Fixture).Include(f => f.WinnerTeam);
            return View(await sportFixturePointContext.ToListAsync());
        }

        // GET: FixtureResults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixtureResult = await _context.FixtureResults
                .Include(f => f.Fixture)
                .Include(f => f.WinnerTeam)
                .FirstOrDefaultAsync(m => m.ResultId == id);
            if (fixtureResult == null)
            {
                return NotFound();
            }

            return View(fixtureResult);
        }

        // GET: FixtureResults/Create
        public IActionResult Create()
        {
            ViewData["FixtureId"] = new SelectList(_context.Fixtures, "FixtureId", "IsFinished");
            ViewData["WinnerTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName");
            return View();
        }

        // POST: FixtureResults/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResultId,FixtureId,HomeTeamScore,AwayTeamScore,WinnerTeamId")] FixtureResult fixtureResult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fixtureResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FixtureId"] = new SelectList(_context.Fixtures, "FixtureId", "IsFinished", fixtureResult.FixtureId);
            ViewData["WinnerTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixtureResult.WinnerTeamId);
            return View(fixtureResult);
        }

        // GET: FixtureResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixtureResult = await _context.FixtureResults.FindAsync(id);
            if (fixtureResult == null)
            {
                return NotFound();
            }
            ViewData["FixtureId"] = new SelectList(_context.Fixtures, "FixtureId", "IsFinished", fixtureResult.FixtureId);
            ViewData["WinnerTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixtureResult.WinnerTeamId);
            return View(fixtureResult);
        }

        // POST: FixtureResults/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResultId,FixtureId,HomeTeamScore,AwayTeamScore,WinnerTeamId")] FixtureResult fixtureResult)
        {
            if (id != fixtureResult.ResultId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fixtureResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FixtureResultExists(fixtureResult.ResultId))
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
            ViewData["FixtureId"] = new SelectList(_context.Fixtures, "FixtureId", "IsFinished", fixtureResult.FixtureId);
            ViewData["WinnerTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixtureResult.WinnerTeamId);
            return View(fixtureResult);
        }

        // GET: FixtureResults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fixtureResult = await _context.FixtureResults
                .Include(f => f.Fixture)
                .Include(f => f.WinnerTeam)
                .FirstOrDefaultAsync(m => m.ResultId == id);
            if (fixtureResult == null)
            {
                return NotFound();
            }

            return View(fixtureResult);
        }

        // POST: FixtureResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fixtureResult = await _context.FixtureResults.FindAsync(id);
            _context.FixtureResults.Remove(fixtureResult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FixtureResultExists(int id)
        {
            return _context.FixtureResults.Any(e => e.ResultId == id);
        }
    }
}
