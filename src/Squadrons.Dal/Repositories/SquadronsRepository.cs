using Squadrons.Dal.Common.Repositories;
using Squadrons.Model.Entities;

namespace Squadrons.Dal.Repositories
{
    public class SquadronsRepository : RepositoryBase<SquadronsTestingDbContext, Squadron>
    {
        protected SquadronsRepository(SquadronsTestingDbContext dbContext) 
            : base(dbContext) { }
    }
}
