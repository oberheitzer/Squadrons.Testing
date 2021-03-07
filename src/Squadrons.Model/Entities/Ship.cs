using Squadrons.Model.Common;

namespace Squadrons.Model.Entities
{
    public class Ship : Entity
    {
        public int PilotId { get; set; }
        public Pilot Pilot { get; set; } = null!;
    }
}
