using Squadrons.Model.Interfaces;
using Squadrons.Model.Common.Repositories;
using Squadrons.Model.Entities;

namespace Squadrons.Dal.Repositories
{
    public class SquadronsRepository : RepositoryBase<SquadronsTestingDbContext, Squadron>, ISquadronsRepository
    {
        public SquadronsRepository(SquadronsTestingDbContext dbContext)
            : base(dbContext) { }
    }
}
