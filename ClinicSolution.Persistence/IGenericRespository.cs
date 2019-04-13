using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ClinicSolution.Persistence
{
    public interface IGenericRepository<T> where T: class
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<IQueryable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<int> AddAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<bool> EditAsync(T entity);
        Task<bool> SaveAsync();
    }
}
