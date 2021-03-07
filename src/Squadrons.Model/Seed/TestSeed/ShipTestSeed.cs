using Squadrons.Model.Entities;
using Squadrons.Model.Enums;

namespace Squadrons.Model.Seed
{
    public class ShipTestSeed : IEntitySeed<Ship>
    {
        public Ship[] Entities => new[]
        {
            new Ship("Red-X-Wing-5d245db6-e90a-4d7c-8451-ba3f97a29c0e", ShipType.XWing, 1) { Id = 1 }
        };
    }
}
