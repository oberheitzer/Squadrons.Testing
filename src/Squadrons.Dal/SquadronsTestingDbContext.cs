using Microsoft.EntityFrameworkCore;
using Squadrons.Model.Entities;
using Squadrons.Model.Seed;
using System.Reflection;

namespace Squadrons.Dal
{
    public class SquadronsTestingDbContext : DbContext
    {
        #region DbSets
        public Squadron Squadrons { get; set; } = null!;
        public Pilot Pilots { get; set; } = null!;
        public Ship Ships { get; set; } = null!;
        #endregion

        public SquadronsTestingDbContext(DbContextOptions<SquadronsTestingDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            SeedDatas(modelBuilder);
        }

        private void SeedDatas(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Squadron>().HasData(new SquadronTestSeed().Entities);
            modelBuilder.Entity<Pilot>().HasData(new PilotTestSeed().Entities);
            modelBuilder.Entity<Ship>().HasData(new ShipTestSeed().Entities);
        }
    }
}
