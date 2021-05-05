using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.UI.Evaluation.Interpretables
{
    public partial class Interpretable<T>
    {
        private class QueryInterpretable : IInterpretable
        {
            public Func<object> CreateQuery { get; }

            public Func<object, T> WithQueryResult { get; }

            public QueryInterpretable(Func<object> createQuery, Func<object, T> withQueryResult)
            {
                CreateQuery = createQuery;
                WithQueryResult = withQueryResult;
            }

            public TResult Match<TResult>(Func<QueryInterpretable, TResult> withQuery)
            {
                return withQuery(this);
            }

            public static implicit operator Interpretable<T>(QueryInterpretable query) => 
                new Interpretable<T>(query);
        }

        public static Interpretable<T> Query<TQuery, TQueryResult>(Func<TQuery> createQuery, Func<TQueryResult, T> withQueryResult) 
        {
            return new QueryInterpretable(() => createQuery(), result => withQueryResult((TQueryResult)result));
        }
    }
}
