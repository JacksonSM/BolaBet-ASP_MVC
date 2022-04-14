using BolaBet.API.Configuration;
using BolaBet.API.EntitiesMatchesAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BolaBet.API.Services.Interfaces
{
    public class MatchesService : IMatchesService
    {
        private readonly IApiConfigMatches _apiConfigMatches;
        private readonly HttpClient _httpClient;

        public MatchesService(IApiConfigMatches apiConfigMatches, HttpClient httpClient)
        {
            _apiConfigMatches = apiConfigMatches;
            _httpClient = httpClient;
           
        }

        public async Task<Partida> GetMatches()
        {
            
            return await _httpClient.GetFromJsonAsync<Partida>(
                $"{_apiConfigMatches.BaseUrl}/v2/matches");
        }
    }
}
