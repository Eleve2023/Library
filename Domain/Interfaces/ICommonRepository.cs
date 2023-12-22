using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICommonRepository<TEntity, TModelDto>
    {
        Task<TEntity> GetByIdAsync(object id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<object> AddItemAsync(TEntity entity);
        Task DeleteItemAsync(object id);
        Task UpdateItemAsync(object id, TModelDto modelDto);
    }
}
