using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ClinicSolution.Persistence
{
    public interface IGenericRepository<T> where T: class
    {
        IQueryable<T> GetAll();
        Task<T> FindAsync(Guid id);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        bool Add(T entity);
        bool Delete(T entity);
        Task<int> SaveAsync();
    }
}
