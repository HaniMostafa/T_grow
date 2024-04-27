using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using T_grow.Data;
using T_grow.Models;

namespace T_grow.Services
{
    public class TreatMent : ITreatment
    {
        private readonly ApplicationDbContext _context;

        public TreatMent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TreatMentModel> Add(TreatMentModel treat)
        {
            await _context.TreatMents.AddAsync(treat);
            _context.SaveChanges();
            return treat;
        }
      

        public async Task<IEnumerable<TreatMentModel>> GetAll()
        {
            return await _context.TreatMents.ToListAsync();
        }

        public Task<TreatMentModel> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public TreatMentModel Update(TreatMentModel treat)
        {
            throw new System.NotImplementedException();
        }
    }
}
