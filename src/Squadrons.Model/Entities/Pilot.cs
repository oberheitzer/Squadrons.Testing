using Squadrons.Model.Common;
using Squadrons.Model.Enums;

namespace Squadrons.Model.Entities
{
    public class Pilot : Entity
    {
        public string Name { get; set; }

        public string CallSign { get; set; } = string.Empty;

        public GenderType Gender { get; set; }

        public PilotType? PilotType { get; set; }

        public int ShipId { get; set; }
        public Ship Ship { get; set; } = null!;

        public int? SquadronId { get; set; }
        public Squadron Squadron { get; set; } = null!;

        public Pilot(string name, GenderType gender, int shipId)
        {
            Name = name;
            Gender = gender;
            ShipId = shipId;
        }
    }
}
