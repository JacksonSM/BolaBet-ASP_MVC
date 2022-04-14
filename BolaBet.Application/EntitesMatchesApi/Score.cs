using Newtonsoft.Json;

namespace BolaBet.Application.EntitiesMatchesApi
{
    public partial class Score
    {
        [JsonProperty("winner")]
        public object Winner { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("fullTime")]
        public ExtraTime FullTime { get; set; }

        [JsonProperty("halfTime")]
        public ExtraTime HalfTime { get; set; }

        [JsonProperty("extraTime")]
        public ExtraTime ExtraTime { get; set; }

        [JsonProperty("penalties")]
        public ExtraTime Penalties { get; set; }
    }
}
