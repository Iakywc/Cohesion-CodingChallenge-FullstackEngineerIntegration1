using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Queries;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Application.Interfaces
{
    public interface IGetServiceRequestByIdQueryHandler
    {
        Task<ServiceRequest> GetServiceRequestById(GetServiceRequestByIdQuery query
            , CancellationToken cancellationToken);
    }
}