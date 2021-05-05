using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Common.Option;

namespace Everest.UI.Evaluation.Instructions
{
    public class QueryFailure
    {
        public string Message { get; }
        public Option<Exception> Exception { get; }

        public QueryFailure(string message)
        {
            Message = message;
        }

        public QueryFailure(Exception exception)
        {
            Exception = exception;
            Message = exception.Message;
        }
    }
}
