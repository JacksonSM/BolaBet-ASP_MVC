using BolaBet.Domain.Entities;
using BolaBet.Domain.Interfaces;
using BolaBet.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
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

        public async Task CreateAsync(Apostador apostador)
        {
            _context.Add(apostador);
            await _context.SaveChangesAsync();
        }

        public async Task<Apostador> GetByIdAsync(int? id)
        {
            return await _context.Apostadores.FindAsync(id);
        }

        public async Task<IEnumerable<Apostador>> GetCategoriesAsync()
        {
            return await _context.Apostadores.ToListAsync();
        }

        public async Task RemoveAsync(Apostador apostador)
        {
            _context.Remove(apostador);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Apostador apostador)
        {
            _context.Update(apostador);
            await _context.SaveChangesAsync();
        }
    }
}
