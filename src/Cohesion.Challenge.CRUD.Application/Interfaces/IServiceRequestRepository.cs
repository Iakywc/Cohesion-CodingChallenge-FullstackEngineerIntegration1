using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Application.Interfaces
{
    public interface IServiceRequestRepository
    {
        Task<ServiceRequest> GetServiceRequestById(string id, CancellationToken cancellationToken);
        Task<IEnumerable<ServiceRequest>> GetAllSerivceRequest(CancellationToken cancellationToken);
        Task CreateServiceRequest(ServiceRequest service, CancellationToken cancellationToken);
        Task UpdateServiceRequest(ServiceRequest service, CancellationToken cancellationToken);
        Task DeleteServiceRequest(string id, CancellationToken cancellationToken);
    }
}