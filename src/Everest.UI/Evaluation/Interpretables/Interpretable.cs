using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Business.Queries;

namespace Everest.UI.Evaluation.Interpretables
{
    public partial class Interpretable<T>
    {
        private readonly IInterpretable implementor;

        private Interpretable(IInterpretable implementor)
        {
            this.implementor = implementor;
        }

        public TResult Match<TResult>(
            Func<(Func<object> CreateQuery, Func<object, T> WithQueryResult), TResult> withQuery)
        {
            return implementor.Match(
                withQuery: query => withQuery((query.CreateQuery, query.WithQueryResult)));
        }

        private interface IInterpretable
        {
            TResult Match<TResult>(Func<QueryInterpretable, TResult> withQuery);
        }

        public static implicit operator Evaluatable<T>(Interpretable<T> interpretable) => Evaluatable<T>.Interpretable(interpretable);
    }
}
