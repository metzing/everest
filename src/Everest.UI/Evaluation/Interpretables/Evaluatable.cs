using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.UI.Evaluation.Interpretables
{
    public class Evaluatable<T>
    {
        private readonly bool isInterpretable;
        private readonly T value;
        private readonly Interpretable<T> interpretable;

        private Evaluatable(bool isInterpretable, T value = default, Interpretable<T> interpretable = default)
        {
            this.isInterpretable = isInterpretable;
            this.value = value;
            this.interpretable = interpretable;
        }

        public TResult Match<TResult>(
            Func<T, TResult> withValue,
            Func<Interpretable<T>, TResult> withInterpretable)
        {
            return isInterpretable ? withInterpretable(interpretable) : withValue(value);
        }

        public static Evaluatable<T> Value(T value) => new Evaluatable<T>(isInterpretable: false, value: value);

        public static Evaluatable<T> Interpretable(Interpretable<T> interpretable) => new Evaluatable<T>(isInterpretable: true, interpretable: interpretable);
    }

    public static class Evaluateable
    {
        public static Evaluatable<T> Value<T>(T value) => Evaluatable<T>.Value(value);

        public static Evaluatable<T> Interpretable<T>(T value) => Evaluatable<T>.Value(value);
    }
}
