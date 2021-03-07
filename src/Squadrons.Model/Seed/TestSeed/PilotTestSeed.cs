using Squadrons.Model.Entities;
using Squadrons.Model.Enums;

namespace Squadrons.Model.Seed
{
    public class PilotTestSeed : IEntitySeed<Pilot>
    {
        public Pilot[] Entities => new[]
        {
            new Pilot("Drego Lerga", GenderType.Male, 1) { Id = 1, PilotType = PilotType.SquadronLeader, SquadronId = 1, CallSign = "Red-1" },
            new Pilot("Vinna Nalle", GenderType.Female, 2) { Id = 2, PilotType = PilotType.Pilot, SquadronId = 1, CallSign = "Red-2" },
            new Pilot("Varlo Braji", GenderType.Male, 3) { Id = 3, PilotType = PilotType.Pilot, SquadronId = 1, CallSign = "Red-3" },
            new Pilot("Airal Beren", GenderType.Female, 4) { Id = 4, PilotType = PilotType.Pilot, SquadronId = 1, CallSign = "Red-4" },
            new Pilot("Ledo Menall", GenderType.Male, 5) { Id = 5, PilotType = PilotType.Pilot, SquadronId = 1, CallSign = "Red-5" },
            new Pilot("Reina Temarch", GenderType.Female, 6) { Id = 6, PilotType = PilotType.Pilot, SquadronId = 1, CallSign = "Red-6" },
            new Pilot("Deng Halcorr", GenderType.Male, 7) { Id = 7, PilotType = PilotType.Pilot, SquadronId = 1, CallSign = "Red-7" },
            new Pilot("Kyla Venau", GenderType.Female, 8) { Id = 8, PilotType = PilotType.Pilot, SquadronId = 1, CallSign = "Red-8" }
        };
    }
}
