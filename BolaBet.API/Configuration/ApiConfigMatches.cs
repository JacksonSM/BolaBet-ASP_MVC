using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BolaBet.API.Configuration
{
    public interface IApiConfigMatches
    {
        public string BaseUrl { get; set; }
    }
    public class ApiConfigMatches : IApiConfigMatches
    {
        public string BaseUrl { get; set; }
    }
}
