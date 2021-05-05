using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Common.Result
{
    public static partial class Result
    {
        public static IEnumerable<TSuccess> WhereSuccess<TSuccess, TFailure>(this IEnumerable<Result<TSuccess, TFailure>> source)
        {
            foreach (var (isSuccess, success, _) in source)
            {
                if (isSuccess)
                {
                    yield return success;
                }
            }
        }
    }
}
