using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Data.Contract.Users
{
    public class UserEntity : IEntity
    {
        public Guid Id { get; set; }
    }
}
