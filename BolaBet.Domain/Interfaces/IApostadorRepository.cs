using BolaBet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaBet.Domain.Interfaces
{
    public interface IApostadorRepository
    {
        Task<IEnumerable<Apostador>> GetCategories();
        Task<Apostador> GetById(int? id);

        Task<Apostador> Create(Apostador apostador);
        Task<Apostador> Update(Apostador apostador);
        Task<Apostador> Remove(Apostador apostador);
    }
}
