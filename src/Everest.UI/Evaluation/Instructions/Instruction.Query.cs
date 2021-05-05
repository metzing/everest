using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Common.Result;

using Everest.Business.Queries;

using Everest.UI.Evaluation.Interpretables;

namespace Everest.UI.Evaluation.Instructions
{
    public static partial class Instruction
    {
        public static Evaluatable<Result<TResult, QueryFailure>> Query<TQuery, TResult>(Func<TQuery> createQuery) where TQuery : IQuery<TResult> =>
            Interpretable<Result<TResult, QueryFailure>>.Query<TQuery, TResult>(
                createQuery, 
                withQueryResult: queryResult => Result<TResult, QueryFailure>.Success(queryResult));
    }
}
