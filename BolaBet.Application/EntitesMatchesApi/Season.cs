using System;
using Newtonsoft.Json;

namespace BolaBet.Application.EntitiesMatchesApi
{
    public partial class Season
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("currentMatchday")]
        public long CurrentMatchday { get; set; }

        [JsonProperty("winner")]
        public object Winner { get; set; }
    }
}
