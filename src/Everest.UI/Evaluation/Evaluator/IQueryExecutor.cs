using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Common.Result;

using Everest.Business.Queries;

using Everest.UI.Evaluation.Instructions;

namespace Everest.UI.Evaluation.Evaluator
{
    public interface IQueryExecutor
    {
        Result<object, QueryFailure> Execute(Func<object> createQuery);

        Result<TQueryResult, QueryFailure> Execute<TQuery, TQueryResult>(Func<TQuery> createQuery) where TQuery : IQuery<TQueryResult>;
    }
}
