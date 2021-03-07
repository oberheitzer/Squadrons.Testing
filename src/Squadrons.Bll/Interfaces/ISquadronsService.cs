using Squadrons.Bll.Dtos;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Squadrons.Bll.Interfaces
{
    public interface ISquadronsService
    {
        Task<List<SquadronListDto>> GetSquadronsAsync(CancellationToken cancellationToken);
    }
}
