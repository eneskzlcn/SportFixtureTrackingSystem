using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SportFixtureTracking.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SportFixtureTracking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SportFixturePointContext _context;
        public HomeController(ILogger<HomeController> logger, SportFixturePointContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            GetClubs();
            GetSports();
            return View();
        }
        private void GetClubs()
        {
            ViewData["Clubs"] = new SelectList(_context.Clubs, "ClubId", "ClubName");
        }
        private void GetSports()
        {
            ViewData["Sports"] = new SelectList(_context.Sports, "SportId", "SportName");
        }
      
  
        public async Task<IActionResult> Query([Bind("SportId")] Team team)
        {
            var teams = _context.Teams.Where(a => a.SportId == team.SportId).ToList();
            ViewData["Teams"] = teams;
            return RedirectToAction("Index","Teams");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
