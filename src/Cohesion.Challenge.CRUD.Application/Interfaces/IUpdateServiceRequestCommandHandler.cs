using System.Threading;
using System.Threading.Tasks;

namespace Cohesion.Challenge.CRUD.Application.Commands
{
    public interface IUpdateServiceRequestCommandHandler
    {
        Task<bool> UpdateServiceRequestById(UpdateServiceRequestCommand command
            , CancellationToken cancellationToken);
    }
}