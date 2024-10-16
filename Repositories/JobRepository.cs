
using _21100744PARCIALWEB.Data;
using _21100744PARCIALWEB.Entities;
using _21100744PARCIALWEB.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace _21100744PARCIALWEB.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly Parcial20240221100744Context _dbContext;

        public JobRepository(Parcial20240221100744Context dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<JobOffer>> GetAllJobs()
        {
            var jobs = await _dbContext.JobOffer.Where(j => j.Id != 0).ToListAsync();
            return jobs;
        }
        public async Task<int> Insert(JobOffer job)
        {
            await _dbContext.JobOffer.AddAsync(job);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0 ? job.Id : -1;
        }
        public async Task<bool> Update(JobOffer job)
        {
            _dbContext.JobOffer.Update(job);
            int rows = await _dbContext.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var job = await _dbContext.JobOffer.FirstOrDefaultAsync(a => a.Id == id);
            _dbContext.JobOffer.Remove(job);

            if (job == null) return false;
            return true;
        }
    }
}
