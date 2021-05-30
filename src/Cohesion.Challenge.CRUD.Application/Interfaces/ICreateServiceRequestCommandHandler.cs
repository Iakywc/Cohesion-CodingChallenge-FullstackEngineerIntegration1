using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Commands;

namespace Cohesion.Challenge.CRUD.Application.Interfaces
{
    public interface ICreateServiceRequestCommandHandler
    {
        Task<bool> CreateServiceRequest(CreateServiceRequestCommand command,
            CancellationToken cancellationToken);
    }
}