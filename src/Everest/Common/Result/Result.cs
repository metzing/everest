using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Common.Result
{
    public class Result<TSuccess, TFailure>
    {
        public T Match<T>(
            Func<TSuccess, T> withSuccess,
            Func<TFailure, T> withFailure);
    }
}
