using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BolaBet.Application.EntitiesMatchesApi
{
    public partial class Match
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("competition")]
        public Competition Competition { get; set; }

        [JsonProperty("season")]
        public Season Season { get; set; }

        [JsonProperty("utcDate")]
        public DateTimeOffset UtcDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("matchday")]
        public long? Matchday { get; set; }

        [JsonProperty("stage")]
        public string Stage { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("odds")]
        public Odds Odds { get; set; }

        [JsonProperty("score")]
        public Score Score { get; set; }

        [JsonProperty("homeTeam")]
        public Team HomeTeam { get; set; }

        [JsonProperty("awayTeam")]
        public Team AwayTeam { get; set; }

        [JsonProperty("referees")]
        public Referee[] Referees { get; set; }


        public string StatusPT { get; set; }

        public Match()
        {
          // Conversao().Wait(TimeSpan.FromSeconds(100));
        }
        public Task Conversao()
        {
            
            if (Status != null)
            {
                switch (Status)
                {
                    case "SCHEDULED":
                        StatusPT = "AGENDADO";
                        break;

                    case "LIVE":
                        StatusPT = "AO VIVO";
                        break;

                    case "IN_PLAY":
                        StatusPT = "EM JOGO";
                        break;
                    case "PAUSED":
                        StatusPT = "INTERVALO";
                        break;
                    case "FINISHED":
                        StatusPT = "TERMINOU";
                        break;

                }
            }
            return null;
        }
    }
}
