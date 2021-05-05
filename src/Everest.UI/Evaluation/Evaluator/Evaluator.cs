using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.UI.Evaluation.Interpretables;

namespace Everest.UI.Evaluation.Evaluator
{
    public class Evaluator : IEvaluator
    {
        private readonly IQueryExecutor queryExecutor;

        public Evaluator(IQueryExecutor queryExecutor)
        {
            this.queryExecutor = queryExecutor;
        }

        public T Evaluate<T>(Evaluatable<T> evaluatable)
        {
            return evaluatable.Match(
                withValue: value => value,
                withInterpretable: interpretable => interpretable.Match(
                    withQuery: query => query.WithQueryResult(queryExecutor.Execute(query.CreateQuery))));
        }
    }
}
