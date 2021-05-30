using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Commands;

namespace Cohesion.Challenge.CRUD.Application.Interfaces
{
    public interface IUpdateServiceRequestCommandHandler
    {
        Task UpdateServiceRequestById(UpdateServiceRequestCommand command
            , CancellationToken cancellationToken);
    }
}