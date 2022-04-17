using BolaBet.Application.EntitiesMatchesApi;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaBet.Application.APIRequest
{
    public interface IMatchesAPIRequest
    {
        [Get("/v2/matches")]
        [Headers("X-Auth-Token: e88aa0504ecb4575bbfab26a2ec6ab7f")]
        Task<Welcome> GetMatchesAsync();
        
        [Get("/v2/competitions/")]
        [Headers("X-Auth-Token: e88aa0504ecb4575bbfab26a2ec6ab7f")]
        Task<Competition[]> GetCompetitionsAsync();
    }
}
