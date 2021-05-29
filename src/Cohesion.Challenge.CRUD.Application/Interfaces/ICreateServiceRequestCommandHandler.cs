using System.Threading;
using System.Threading.Tasks;

namespace Cohesion.Challenge.CRUD.Application.Commands
{
    public interface ICreateServiceRequestCommandHandler
    {
        Task<bool> CreateServiceRequest(CreateServiceRequestCommand command,
            CancellationToken cancellationToken);
    }
}