using Newtonsoft.Json;

namespace BolaBet.Application.EntitiesMatchesApi
{
    public partial class Welcome
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("filters")]
        public Filters Filters { get; set; }

        [JsonProperty("matches")]
        public Match[] Matches { get; set; }
    }
}
