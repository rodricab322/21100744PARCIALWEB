using _21100744PARCIALWEB.Entities;

namespace _21100744PARCIALWEB.Interfaces
{
    public interface ICompetencyRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Competency>> GetAll();
        Task<int> Insert(Competency competency);
        Task<bool> Update(Competency competency);
    }
}