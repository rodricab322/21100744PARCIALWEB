using _21100744PARCIALWEB.Data;
using _21100744PARCIALWEB.Entities;
using _21100744PARCIALWEB.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _21100744PARCIALWEB.Repositories
{
    public class CompetencyRepository : ICompetencyRepository
    {
        private readonly Parcial20240221100744Context _dbContext;

        public CompetencyRepository(Parcial20240221100744Context dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Competency>> GetAll()
        {
            var competencies = await _dbContext.Competency.Where(c => c.Id != 0).ToListAsync();
            return competencies;
        }
        public async Task<int> Insert(Competency competency)
        {
            await _dbContext.Competency.AddAsync(competency);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0 ? competency.Id : -1;
        }
        public async Task<bool> Update(Competency competency)
        {
            _dbContext.Competency.Update(competency);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var competency = await _dbContext.Competency.FirstOrDefaultAsync(a => a.Id == id);
            _dbContext.Competency.Remove(competency);

            if (competency == null) return false;
            return true;
        }
    }
}
