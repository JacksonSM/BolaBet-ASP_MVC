using Newtonsoft.Json;

namespace BolaBet.Application.EntitiesMatchesApi
{
    public partial class Odds
    {
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
