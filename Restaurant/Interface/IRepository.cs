using Restaurant.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Interface
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate = null);
        //Task<TEntity> AddAsync(TEntity item);
        //Task<TEntity> UpdateAsync(int id, TEntity item);
        //Task<bool> RemoveAsync(int id);
        //Task DeleteAsync(int id);
        //Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);
        //Task<TEntity> LastOrDefault(Expression<Func<TEntity, bool>> expression = null);
        //Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> expression = null);
    }
}
