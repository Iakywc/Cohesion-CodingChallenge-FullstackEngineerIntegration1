using System;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Interfaces;

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
        private readonly IServiceRequestRepository _requestRepository;

        public DeleteServiceRequestCommandHandler(IServiceRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<bool> DeleteServiceRequestById(DeleteServiceRequestCommand command,
            CancellationToken cancellationToken)
        {
            try
            {
                await _requestRepository.DeleteServiceRequest(command.Id.ToString(), cancellationToken);

                return true;
            }
            catch (Exception e)
            {
                //Log error and return result
                return false;
            }
        }
    }
}
