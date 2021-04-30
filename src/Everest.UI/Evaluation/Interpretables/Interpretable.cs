using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Business.Queries;

namespace Everest.UI.Evaluation.Interpretables
{
    public class Interpretable<T>
    {
        public TResult Match<TResult>(
            Func<IQuery<T>, TResult> withQuery,
            )

        public static implicit operator Evaluatable<T>(Interpretable<T> interpretable) => Evaluatable<T>.Interpretable(interpretable);
    }
}
