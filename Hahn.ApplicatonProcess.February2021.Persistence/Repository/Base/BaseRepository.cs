using Hahn.ApplicatonProcess.February2021.Domain.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Data.Repository.Base
{
    public abstract class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : class
    {
        protected readonly DbContext DatabaseContext;

        public BaseRepository(DbContext context)
        {
            this.DatabaseContext = context;
        }
        public async Task<TModel> GetAsync(int id)
        {
            return await DatabaseContext.Set<TModel>().FindAsync(id);
        }
        public async Task UpdateAsync(TModel entity)
        {
            DatabaseContext.Set<TModel>().Update(entity);
            await DatabaseContext.SaveChangesAsync();
        }
        public async Task AddAsync(TModel entity)
        {
            await DatabaseContext.Set<TModel>().AddAsync(entity);
            DatabaseContext.SaveChanges();
        }
        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var dbSet = DatabaseContext.Set<TModel>();
            return await dbSet.ToListAsync();
        }

        public async Task RemoveByIdAsync(int id)
        {
            var existingEntity = await DatabaseContext.Set<TModel>().FindAsync(id);
            DatabaseContext.Remove(existingEntity);
            DatabaseContext.SaveChanges();
        }
    }
}
