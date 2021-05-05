using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Common.Result
{
    public class Result<TSuccess, TFailure>
    {
        private readonly TSuccess success;
        private readonly TFailure failure;

        public bool IsSuccess { get; }

        private Result(bool isSuccess, TSuccess success, TFailure failure)
        {
            IsSuccess = isSuccess;
            this.success = success;
            this.failure = failure;
        }

        public T Match<T>(
            Func<TSuccess, T> withSuccess,
            Func<TFailure, T> withFailure)
        {
            return IsSuccess ? withSuccess(success) : withFailure(failure);
        }

        public void Deconstruct(out bool isSuccess, out TSuccess success, out TFailure failure)
        {
            (isSuccess, success, failure) = (IsSuccess, this.success, this.failure);
        }

        public static Result<TSuccess, TFailure> Success(TSuccess success) => new Result<TSuccess, TFailure>(isSuccess: true, success, default);

        public static Result<TSuccess, TFailure> Failure(TFailure failure) => new Result<TSuccess, TFailure>(isSuccess: false, default, failure);
    }

    public static partial class Result
    {
        public static Result<TSuccess, TFailure> Success<TSuccess, TFailure>(TSuccess success) => Result<TSuccess, TFailure>.Success(success);

        public static Result<TSuccess, TFailure> Failure<TSuccess, TFailure>(TFailure failure) => Result<TSuccess, TFailure>.Failure(failure);

        #region Map

        public static Result<TSuccessTarget, TFailureTarget> Map<TSuccessSource, TFailureSource, TSuccessTarget, TFailureTarget>(
            this Result<TSuccessSource, TFailureSource> source,
            Func<TSuccessSource, TSuccessTarget> mapSuccess,
            Func<TFailureSource, TFailureTarget> mapFailure)
        {
            return source.Match(
                withSuccess: success => Result.Success<TSuccessTarget, TFailureTarget>(mapSuccess(success)),
                withFailure: failure => Result.Failure<TSuccessTarget, TFailureTarget>(mapFailure(failure)));
        }

        public static Result<TSuccessTarget, TFailure> MapSuccess<TSuccessSource, TSuccessTarget, TFailure>(
            this Result<TSuccessSource, TFailure> source,
            Func<TSuccessSource, TSuccessTarget> map) 
            => source.Map(mapSuccess: map, mapFailure: failure => failure);

        public static Result<TSuccess, TFailureTarget> MapFailure<TSuccess, TFailureSource, TFailureTarget>(
            this Result<TSuccess, TFailureSource> source,
            Func<TFailureSource, TFailureTarget> map)
            => source.Map(mapSuccess: success => success, mapFailure: map);

        #endregion
    }
}
