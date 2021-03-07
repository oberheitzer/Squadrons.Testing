using Squadrons.Model.Entities;
using Squadrons.Model.Enums;

namespace Squadrons.Model.Seed
{
    public class SquadronTestSeed : IEntitySeed<Squadron>
    {
        public Squadron[] Entities => new[]
        {
            new Squadron("Red", SquadronType.Fighter) { Id = 1 },
            new Squadron("Blue", SquadronType.Fighter) { Id = 2 }
        };
    }
}
