using Squadrons.Model.Entities;
using System;
using System.Linq.Expressions;

namespace Squadrons.Bll.Dtos
{
    public class SquadronListDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Pilots { get; set; }

        public static Expression<Func<Squadron, SquadronListDto>> Projection
        {
            get
            {
                return entity => new SquadronListDto
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Pilots = entity.Pilots.Count
                };
            }
        }
    }
}
