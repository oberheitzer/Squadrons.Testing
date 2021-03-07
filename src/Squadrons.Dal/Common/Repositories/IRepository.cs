using Squadrons.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Squadrons.Dal.Common.Repositories
{
    public interface IRepository<TEntity> where TEntity: Entity
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includes);

        Task<List<TResult>> GetAllListInlcludingAsync<TResult>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes);
    }
}
