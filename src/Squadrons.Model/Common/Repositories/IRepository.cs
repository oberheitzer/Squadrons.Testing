using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Squadrons.Model.Common.Repositories
{
    public interface IRepository<TEntity> where TEntity: Entity
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includes);

        Task<List<TResult>> GetAllListInlcludingAsync<TResult>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TResult>> selector, CancellationToken cancellationToken, params Expression<Func<TEntity, object>>[] includes);
    }
}
