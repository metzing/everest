using System;

namespace Everest.Data.Infrastructure
{
    public class EverestDataInfrastructure : IEverestDataInfrastructure
    {
        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public ITable<TEntity> GetTable<TEntity>() where TEntity : IEntity
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
