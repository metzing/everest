using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Business.Contract.Surveys
{
    public class Survey
    {
        public string Name { get; }

        public Survey(string name)
        {
            Name = name;
        }
    }
}
