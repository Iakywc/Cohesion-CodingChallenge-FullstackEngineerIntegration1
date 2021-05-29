using System;
using System.Threading;
using System.Threading.Tasks;

namespace Cohesion.Challenge.CRUD.Application.Commands
{
    public class DeleteServiceRequestCommand
    {
        public DeleteServiceRequestCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }

    public class DeleteServiceRequestCommandHandler : IDeleteServiceRequestCommandHandler
    {
        public DeleteServiceRequestCommandHandler()
        {
            
        }

        public async Task<bool> DeleteServiceRequestById(DeleteServiceRequestCommand command,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
