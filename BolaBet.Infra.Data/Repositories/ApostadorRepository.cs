using BolaBet.Domain.Entities;
using BolaBet.Domain.Interfaces;
using BolaBet.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolaBet.Infra.Data.Repositories
{
    public class ApostadorRepository : IApostadorRepository
    {
        private readonly ApplicationDbContext _context;

        public ApostadorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Apostador> Create(Apostador apostador)
        {
            throw new NotImplementedException();
        }

        public Task<Apostador> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Apostador>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Apostador> Remove(Apostador apostador)
        {
            throw new NotImplementedException();
        }

        public Task<Apostador> Update(Apostador apostador)
        {
            throw new NotImplementedException();
        }
    }
}
