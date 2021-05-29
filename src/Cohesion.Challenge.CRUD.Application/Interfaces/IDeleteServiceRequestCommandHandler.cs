using System.Threading;
using System.Threading.Tasks;

namespace Cohesion.Challenge.CRUD.Application.Commands
{
    public interface IDeleteServiceRequestCommandHandler
    {
        Task<bool> DeleteServiceRequestById(DeleteServiceRequestCommand command,
            CancellationToken cancellationToken);
    }
}