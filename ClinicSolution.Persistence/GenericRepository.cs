using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSolution.Persistence
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbContext _Context;
        protected DbSet<T> _DbSet;

        public GenericRepository(DbContext context)
        {
            _Context = context ?? throw new ArgumentNullException(nameof(context));
            _DbSet = _Context.Set<T>();
        }

        public bool Add(T entity)
        {
            T result = _DbSet.Add(entity);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            T result = _DbSet.Remove(entity);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Task<T> FindAsync(Guid id)
        {
            return _DbSet.FindAsync(id);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _DbSet.Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _DbSet;
        }

        public Task<int> SaveAsync()
        {
            return _Context.SaveChangesAsync();
        }
    }
}
