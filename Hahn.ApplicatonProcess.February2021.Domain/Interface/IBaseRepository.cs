using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Interface
{
    public interface IBaseRepository<TModel> where TModel : class
    {
        Task<TModel> GetAsync(int id);
        Task<IEnumerable<TModel>> GetAllAsync();
        Task RemoveByIdAsync(int id);
        Task UpdateAsync(TModel entity);
        Task AddAsync(TModel entity);
    }
}
