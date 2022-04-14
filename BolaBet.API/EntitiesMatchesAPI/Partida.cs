using Newtonsoft.Json;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaBet.API.EntitiesMatchesAPI
{
    public class Partida
    {
        //[FromHeader(Name = "utcDate")]
        [JsonProperty("utcDate")]
        public DateTime utcDate { get; set; }
        [JsonProperty("status")]
        public string Estado { get; set; }
        [JsonProperty("matchday")]
        public int DiaJogo { get; set; }

        [JsonProperty("competition")]
        public Competition Campeonato { get; set; }

        [JsonProperty("homeTeam")]
        public Time TimeCasa { get; set; }

        [JsonProperty("awayTeam")]
        public Time TimeFora { get; set; }
    }
}
