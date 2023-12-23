using Application.Helpe;
using AutoMapper;
using Domain.Entities.Works;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Services
{
    public abstract class CommonRepository<TEntity, TModelDto>(AppDbContext appDbContext, MapperHelpe mapper): ICommonRepository<TEntity, TModelDto> where TEntity : class
    {
        protected readonly AppDbContext appDbContext = appDbContext;
        protected readonly MapperHelpe mapper = mapper;

        public virtual async Task<object> AddItemAsync(TEntity entity)
        {
            var entityEntry = appDbContext.Entry(entity);
            entityEntry.State = EntityState.Added;
            await appDbContext.SaveChangesAsync();
            var primaryKeyProperty = entityEntry.Metadata.FindPrimaryKey()!.Properties[0];
            var primaryKeyValue = entityEntry.Property(primaryKeyProperty.Name).CurrentValue;
            return primaryKeyValue!;
        }

        public async Task DeleteItemAsync(object id)
        {
            var entity = await appDbContext.Set<TEntity>().FindAsync(id)
                ?? throw new Domain.Exceptions.WorkTypeNotFoundException(id);
            appDbContext.Remove(entity);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await appDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return await appDbContext.Set<TEntity>().FindAsync(id)
               ?? throw new Domain.Exceptions.WorkTypeNotFoundException(id);
        }

        public async Task UpdateItemAsync(object id, TModelDto modelDto)
        {
            var entity = await appDbContext.Set<TEntity>().FindAsync(id)
               ?? throw new Domain.Exceptions.WorkTypeNotFoundException(id);
            var entityEntry = appDbContext.Entry<TEntity>(entity);
            entityEntry.State = EntityState.Modified;
            entity = mapper.GetT(modelDto, entity);
            entityEntry.References.ToList().ForEach(e => { if (e.TargetEntry != null) e.TargetEntry.State = EntityState.Unchanged; });
            foreach (var item in entityEntry.Properties)
            {
                if (item.CurrentValue == null && item.OriginalValue == null || item.CurrentValue?.Equals(item.OriginalValue) == true)
                    item.IsModified = false;
            }
            await appDbContext.SaveChangesAsync();
        }
    }
}
