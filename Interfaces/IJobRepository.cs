using _21100744PARCIALWEB.Entities;

namespace _21100744PARCIALWEB.Interfaces
{
    public interface IJobRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<JobOffer>> GetAllJobs();
        Task<int> Insert(JobOffer job);
        Task<bool> Update(JobOffer job);
    }
}