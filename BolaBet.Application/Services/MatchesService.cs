using BolaBet.Application.EntitiesMatchesApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Refit;
using System.Threading.Tasks;
using BolaBet.Application.APIRequest;
using BolaBet.Application.Interface;

namespace BolaBet.Application.Services
{
    public class MatchesService : IMatchesService
    {
        private readonly IMatchesAPIRequest _matchesClient;
        public MatchesService()
        {
            _matchesClient = RestService.For<IMatchesAPIRequest>("https://api.football-data.org");
        }
        public async Task<Welcome> GetMatchesAsync()
        {
            return await _matchesClient.GetMatchesAsync();
        }
    }
}
