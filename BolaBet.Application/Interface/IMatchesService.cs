using BolaBet.Application.EntitiesMatchesApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaBet.Application.Interface

{
    public interface IMatchesService
    {
        Task<Welcome> GetMatchesAsync();
    }
}
