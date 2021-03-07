using Squadrons.Bll.Dtos;
using Squadrons.Bll.Interfaces;
using Squadrons.Model.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Squadrons.Bll.Services
{
    public class SquadronsService : ISquadronsService
    {
        private readonly ISquadronsRepository _squadronsRepository;

        public SquadronsService(ISquadronsRepository squadronsRepository)
        {
            _squadronsRepository = squadronsRepository;
        }

        public async Task<List<SquadronListDto>> GetSquadronsAsync(CancellationToken cancellationToken)
        {
            return await _squadronsRepository.GetAllListInlcludingAsync(_ => true, SquadronListDto.Projection, cancellationToken, ent => ent.Pilots);
        }
    }
}
