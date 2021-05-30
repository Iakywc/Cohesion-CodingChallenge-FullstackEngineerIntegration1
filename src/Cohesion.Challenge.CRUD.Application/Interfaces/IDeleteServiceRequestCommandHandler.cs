using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Commands;

namespace Cohesion.Challenge.CRUD.Application.Interfaces
{
    public interface IDeleteServiceRequestCommandHandler
    {
        Task<bool> DeleteServiceRequestById(DeleteServiceRequestCommand command,
            CancellationToken cancellationToken);
    }
}