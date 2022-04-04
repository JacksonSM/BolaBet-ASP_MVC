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
        Task<IEnumerable<Apostador>> GetCategoriesAsync();
        Task<Apostador> GetByIdAsync(int? id);

        Task CreateAsync(Apostador apostador);
        Task UpdateAsync(Apostador apostador);
        Task RemoveAsync(Apostador apostador);
    }
}
