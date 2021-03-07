using Squadrons.Model.Common;
using Squadrons.Model.Enums;
using System.Collections.Generic;

namespace Squadrons.Model.Entities
{
    public class Squadron : Entity
    {
        public string Name { get; set; }

        public SquadronType Type { get; set; }

        private readonly List<Pilot> _pilots = new List<Pilot>();
        public IReadOnlyCollection<Pilot> Pilots => _pilots.AsReadOnly();

        public Squadron(string name, SquadronType type)
        {
            Name = name;
            Type = type;
        }
    }
}
