using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Business.Commands;
using Everest.Business.Queries;
using Everest.Data.Infrastructure;

namespace Everest.Business.Infrastructure
{
    public interface IEverestBusinessInfrastructure : IDisposable
    {
        void Initialize(IEverestDataInfrastructure data);

        ICommandHandler<TCommand> GetCommandHandler<TCommand>() where TCommand : ICommand;

        IQueryHandler<TQuery, TResult> GetQueryHandler<TQuery, TResult>() where TQuery : IQuery<TResult>;
    }
}
