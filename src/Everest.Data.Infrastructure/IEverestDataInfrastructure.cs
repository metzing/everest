using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Data.Infrastructure
{
    public interface IEverestDataInfrastructure : IDisposable
    {
        void Initialize();

        ITable<TEntity> GetTable<TEntity>() where TEntity : IEntity;
    }
}
