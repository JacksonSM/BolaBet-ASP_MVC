using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaBet.API.EntitiesMatchesAPI
{
    public class Time
    {
        [JsonProperty("name")]
        public string Nome { get; set; }
    }
}
