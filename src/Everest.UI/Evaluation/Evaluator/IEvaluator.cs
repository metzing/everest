using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.UI.Evaluation.Interpretables;

namespace Everest.UI.Evaluation.Evaluator
{
    public interface IEvaluator
    {
        public T Evaluate<T>(Evaluatable<T> evaluatable);
    }
}
