using System;

using Everest.Business.Commands;
using Everest.Business.Queries;

using Everest.Data.Infrastructure;

namespace Everest.Business.Infrastructure
{
    public class EverestBusinessInfrastructure : IEverestBusinessInfrastructure
    {
        public EverestBusinessInfrastructure()
        {

        }

        public void Initialize(IEverestDataInfrastructure data)
        {
            throw new NotImplementedException();
        }

        public ICommandHandler<TCommand> GetCommandHandler<TCommand>() where TCommand : ICommand
        {
            throw new NotImplementedException();
        }

        public IQueryHandler<TQuery, TResult> GetQueryHandler<TQuery, TResult>() where TQuery : IQuery<TResult>
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
