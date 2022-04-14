using System;
using Newtonsoft.Json;

namespace BolaBet.Application.EntitiesMatchesApi
{
    public partial class Filters
    {
        [JsonProperty("dateFrom")]
        public DateTimeOffset DateFrom { get; set; }

        [JsonProperty("dateTo")]
        public DateTimeOffset DateTo { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }
    }
}
