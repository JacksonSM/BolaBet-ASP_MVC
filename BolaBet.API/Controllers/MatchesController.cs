using BolaBet.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BolaBet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly IMatchesService _matchesService;

        public MatchesController(IMatchesService matchesService)
        {
            _matchesService = matchesService;
        }
        
        [HttpGet("/v2/matches")]
        
        public async Task<ActionResult> GetMatches()
        {
            HttpContext.Response.Headers.Add("X-Auth-Token", "e88aa0504ecb4575bbfab26a2ec6ab7f");
            return Ok(await _matchesService.GetMatches());
        }
    }
}
