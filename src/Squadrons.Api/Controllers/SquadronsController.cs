using Microsoft.AspNetCore.Mvc;
using Squadrons.Bll.Dtos;
using Squadrons.Bll.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Squadrons.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SquadronsController : ControllerBase
    {
        private readonly ISquadronsService _squadronsService;

        public SquadronsController(ISquadronsService squadronsService)
        {
            _squadronsService = squadronsService;
        }

        [HttpGet]
        public Task<List<SquadronListDto>> GetSquadrons()
        {
            return _squadronsService.GetSquadronsAsync(HttpContext.RequestAborted);
        }
    }
}
