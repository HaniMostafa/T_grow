using System.Collections.Generic;
using System.Threading.Tasks;
using T_grow.Models;

namespace T_grow.Services
{
    public interface ITreatment
    {
        Task<IEnumerable<TreatMentModel>> GetAll();
        Task<TreatMentModel> GetById(int id);
        Task<TreatMentModel> Add(TreatMentModel treat);
        TreatMentModel Update(TreatMentModel treat);
    }
}
