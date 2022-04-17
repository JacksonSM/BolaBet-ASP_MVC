using BolaBet.Application.EntitiesMatchesApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Refit;
using System.Threading.Tasks;
using BolaBet.Application.APIRequest;
using BolaBet.Application.Interface;
using BolaBet.Application.Entities;

namespace BolaBet.Application.Services
{
    public class MatchesService : IMatchesService
    {
        private readonly IMatchesAPIRequest _matchesClient;
        public MatchesService()
        {
            _matchesClient = RestService.For<IMatchesAPIRequest>("https://api.football-data.org");
        }


        public async Task<List<CompetitionsMatches>> GetCompetitionsMatchesAsync()
        {
            var matches = await _matchesClient.GetMatchesAsync();

            var listCompetition = new List<Competition>();
            var listMatches = matches.Matches.ToList();
            var listCompetitionsMatches = new List<CompetitionsMatches>();

            foreach (Match match in matches.Matches)
            {
                if (!listCompetition.Exists(x => x.Id == match.Competition.Id))
                {
                    listCompetition.Add(match.Competition);
                }
            }

            foreach(Competition competition in listCompetition)
            {
                listMatches.Clear();
                var listaMatchesFiltrada = matches.Matches.Select(x => x).Where(x => x.Competition.Id == competition.Id).ToList();

                //foreach (Match match in matches.Matches)
                //{
                //    if (competition.Id == match.Competition.Id)
                //    {
                //        listMatches.Add(match);                        
                //    }

                //}
                listCompetitionsMatches.Add(new CompetitionsMatches() {Competitions = competition, Matches = listaMatchesFiltrada});
            }
            return listCompetitionsMatches;
        }

        public async Task<Welcome> GetMatchesAsync()
        {
            return await _matchesClient.GetMatchesAsync();
        }
    }
}
