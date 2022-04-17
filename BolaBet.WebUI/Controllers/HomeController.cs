using BolaBet.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BolaBet.Application.Interface;

namespace BolaBet.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMatchesService _matchesService;

        public HomeController(IMatchesService matchesService)
        {
            _matchesService = matchesService;
        }

        public async Task<IActionResult> Index()
        {
            var competitionsMatches = await _matchesService.GetCompetitionsMatchesAsync();
            //CompetitionsMatches competitionsMatches = new CompetitionsMatches(matches.Matches.ToList());
            //competitionsMatches.PovoaCompetitions();
            //ViewBag.Lista(competitionsMatches);
       
            return View(competitionsMatches);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
