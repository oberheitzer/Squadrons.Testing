using Microsoft.EntityFrameworkCore;
using Squadrons.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Squadrons.Dal.Common.Repositories
{
    public class RepositoryBase<TDbContext, TEntity> : IRepository<TEntity> 
        where TDbContext : DbContext
        where TEntity : Entity
    {
        private readonly TDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        protected RepositoryBase(TDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includes)
        {
            var query = GetAll();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query.Include(include);
                }
            }

            return query;
        }

        public Task<List<TResult>> GetAllListInlcludingAsync<TResult>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return GetAllIncluding(includes).Where(predicate).Select(selector).ToListAsync();
        }
    }
}
