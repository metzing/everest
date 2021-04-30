using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Data
{
    // stuff the actual DAL can rely on for each entity it has to store
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
