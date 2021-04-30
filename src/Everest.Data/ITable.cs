using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Data
{
    public interface ITable<TEntity> : IQueryable<TEntity> 
        where TEntity : IEntity
    {
        void CreateEntity(TEntity entity);
    }
}
