using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Application.Queries
{
    public interface IGetServiceRequestByIdQueryHandler
    {
        Task<ServiceRequest> GetServiceRequestById(GetServiceRequestByIdQuery query
            , CancellationToken cancellationToken);
    }
}