namespace Squadrons.Model.Seed
{
    interface IEntitySeed<out TEntity> where TEntity : class
    {
        TEntity[] Entities { get; }
    }
}
