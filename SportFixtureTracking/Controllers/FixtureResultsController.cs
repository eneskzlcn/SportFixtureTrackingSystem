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
            var sportFixturePointContext = _context.FixtureResults.Include(f => f.Fixture).ThenInclude(f => f.AwayTeam).Include(f=>f.Fixture.HomeTeam)
                .Include(f => f.WinnerTeam);
            return View(await sportFixturePointContext.ToListAsync());
        }

        // GET: FixtureResults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var fixtureResult = await _context.FixtureResults.FindAsync(id);
            var fixtureResult = await _context.FixtureResults.Include(f => f.Fixture).ThenInclude(f => f.AwayTeam).Include(f => f.Fixture.HomeTeam)
                .Include(f => f.WinnerTeam).FirstOrDefaultAsync(r=> r.ResultId == id);
            if (fixtureResult == null)
            {
                return NotFound();
            }
            ViewData["WinnerTeamId"] = new SelectList(_context.Teams.Where(f => f.TeamId == fixtureResult.Fixture.AwayTeamId || f.TeamId == fixtureResult.Fixture.HomeTeamId), "TeamId", "TeamName", fixtureResult.WinnerTeamId);
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
            ViewData["FixtureId"] = new SelectList(_context.Fixtures, "FixtureId", "IsFinished", fixtureResult.Fixture_Id);
            ViewData["WinnerTeamId"] = new SelectList(_context.Teams, "TeamId", "TeamName", fixtureResult.WinnerTeamId);
            return View(fixtureResult);
        }

        public async Task<IActionResult> Point()
        {
            var sportFixturePointContext = await _context.FixtureResults.Include(f => f.Fixture).ThenInclude(f => f.AwayTeam).Include(f => f.Fixture.HomeTeam)
                .Include(f => f.WinnerTeam).ToListAsync();
            var teamTotalPoints = new Dictionary<Team, int>();
           
          
            foreach(var item in sportFixturePointContext)
            {
                if(teamTotalPoints.ContainsKey(item.Fixture.AwayTeam))
                {
                    teamTotalPoints[item.Fixture.AwayTeam] = teamTotalPoints[item.Fixture.AwayTeam] + Convert.ToInt32(item.AwayTeamScore);
                }
                else
                {
                    teamTotalPoints[item.Fixture.AwayTeam] = Convert.ToInt32(item.AwayTeamScore);
                }
                if(teamTotalPoints.ContainsKey(item.Fixture.HomeTeam))
                {
                    teamTotalPoints[item.Fixture.HomeTeam] = teamTotalPoints[item.Fixture.HomeTeam] + Convert.ToInt32(item.HomeTeamScore);
                }
                else
                {
                    teamTotalPoints[item.Fixture.HomeTeam] = Convert.ToInt32(item.HomeTeamScore);
                }
            }
           
            ViewData["TeamPointPairs"] = teamTotalPoints;
            return View(nameof(Point));
        }

        private bool FixtureResultExists(int id)
        {
            return _context.FixtureResults.Any(e => e.ResultId == id);
        }
    }
}
