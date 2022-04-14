
using BolaBet.API.EntitiesMatchesAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BolaBet.API.Services
{
    public interface IMatchesService
    {
       Task<Partida> GetMatches();
    }
}
