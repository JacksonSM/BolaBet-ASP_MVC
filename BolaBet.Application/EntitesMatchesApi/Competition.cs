using Newtonsoft.Json;

namespace BolaBet.Application.EntitiesMatchesApi
{
    public partial class Competition
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("area")]
        public Area Area { get; set; }
    }
}
