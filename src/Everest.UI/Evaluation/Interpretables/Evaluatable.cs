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

        private Evaluatable(T value = default, Interpretable<T> interpretable = default)
        {
            if (value.Equals(default(T)) && interpretable == default(Interpretable<T>))
            {
                throw new InvalidOperationException("Value or Interpretable must be provided");
            }

            isInterpretable = interpretable is not null;

            this.value = value;
            this.interpretable = interpretable;
        }


        public TResult Match<TResult>(
            Func<T, TResult> withValue,
            Func<Interpretable<T>, TResult> withInterpretable)
        {
            return isInterpretable ? withInterpretable(interpretable) : withValue(value);
        }

        public static Evaluatable<T> Value(T value) => new Evaluatable<T>(value: value);

        public static Evaluatable<T> Interpretable(Interpretable<T> interpretable) => new Evaluatable<T>(interpretable: interpretable);
    }
    public static class Evaluateable
    {
        public static Evaluatable<T> Value<T>(T value) => Evaluatable<T>.Value(value);

        public static Evaluatable<T> Interpretable<T>(T value) => Evaluatable<T>.Value(value);
    }
}
