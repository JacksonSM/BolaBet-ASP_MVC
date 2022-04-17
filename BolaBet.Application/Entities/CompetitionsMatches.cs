using BolaBet.Application.EntitiesMatchesApi;
using System.Collections.Generic;

namespace BolaBet.Application.Entities
{
    public class CompetitionsMatches
    {
        public Competition Competitions { get; set; }
        public List<Match> Matches { get; set; }
       
    }
    
}
