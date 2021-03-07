using Squadrons.Model.Common;
using Squadrons.Model.Enums;

namespace Squadrons.Model.Entities
{
    public class Ship : Entity
    {
        public string TransponderCode { get; set; } = string.Empty;

        public ShipType Type { get; set; }

        public int PilotId { get; set; }
        public Pilot Pilot { get; set; } = null!;

        public Ship(string transponderCode, ShipType type, int pilotId)
        {
            TransponderCode = transponderCode;
            Type = type;
            PilotId = pilotId;
        }
    }
}
