using AutoMapper;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public abstract class CommonService<TEntity, TModelDto>(ICommonRepository<TEntity, TModelDto> commonRepository, IMapper mapper)
    {
        private readonly ICommonRepository<TEntity, TModelDto> commonRepository = commonRepository;

        public virtual async Task<IEnumerable<TModelDto>> GetAsync()
        {
            IEnumerable<TEntity> entities = await commonRepository.GetAllAsync();
            return mapper.Map<List<TModelDto>>(entities);

        }
        public virtual async Task<TModelDto> GetAsync(object id)
        {
            var entity = await commonRepository.GetByIdAsync((int)id);
            return mapper.Map<TModelDto>(entity);
        }

        public virtual async Task<object> AddAsync(TModelDto modelDto)
        {
            var entity = mapper.Map<TEntity>(modelDto);
            return await commonRepository.AddItemAsync(entity);
        }

        public virtual async Task DeleteAsync(object id)
        {
           await commonRepository.DeleteItemAsync(id);
        }

        public virtual async Task UpdateAsync(object id, TModelDto modelDto)
        {
            await commonRepository.UpdateItemAsync(id, modelDto);
        }
    }
}
