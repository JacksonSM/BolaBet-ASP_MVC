using Newtonsoft.Json;

namespace BolaBet.Application.EntitiesMatchesApi
{
    public partial class ExtraTime
    {
        [JsonProperty("homeTeam")]
        public object HomeTeam { get; set; }

        [JsonProperty("awayTeam")]
        public object AwayTeam { get; set; }
    }
}
