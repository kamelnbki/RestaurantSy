using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OpenQA.Selenium;
using Restaurant.Data;
using Restaurant.Data.Entity;
using Restaurant.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Services
{
   public class RepositoryService<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        protected readonly DbSet<TEntity> table;
        public RepositoryService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            table = applicationDbContext.Set<TEntity>();
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            var result = await table.Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (result is null)
                throw new NotFoundException($"{typeof(TEntity).Name} not found");

            return result;
        }

        public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            var query = table.AsQueryable();

            if (predicate != null)
                query = query.Where(predicate);

            return await query.ToListAsync();
        }
    }
}
