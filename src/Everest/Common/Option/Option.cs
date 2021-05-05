using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Common.Option
{
    public struct Option<T>
    {
        private readonly T some;

        public bool IsSome { get; }

        private Option(bool isSome, T some)
        {
            IsSome = isSome;
            this.some = some;
        }

        public TResult Match<TResult>(
            Func<T, TResult> withSome,
            Func<TResult> withNone)
        {
            return IsSome ? withSome(some) : withNone();
        }

        public static Option<T> Some(T some) => new Option<T>(isSome: true, some);

        public static Option<T> None { get; } = new Option<T>(isSome: false, default);

        public static implicit operator Option<T>(T some) => Some(some);
    }

    public static partial class Option
    {
        public static Option<T> None<T>() => Option<T>.None;
        public static Option<T> Some<T>(T some) => Option<T>.Some(some);
    }
}
