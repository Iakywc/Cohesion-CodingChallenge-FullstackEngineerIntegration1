using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Application.Queries
{
    public interface IGetAllServiceRequestQueryHandler
    {
        Task<IEnumerable<ServiceRequest>> GetAllServiceRequests(CancellationToken cancellationToken);
    }
}