using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Business.Queries;
using Everest.UI.Evaluation.Interpretables;

namespace Everest.UI.Evaluation.Instructions
{
    public static partial class Instruction
    {
        public static Evaluatable<TResult> Query<TQuery, TResult>(Func<TQuery> createQuery) where TQuery : IQuery<TResult> =>
            Eva
    }
}
