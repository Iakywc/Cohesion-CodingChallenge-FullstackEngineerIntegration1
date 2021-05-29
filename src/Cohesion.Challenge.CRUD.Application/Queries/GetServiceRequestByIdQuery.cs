using System;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Application.Queries
{
    public class GetServiceRequestByIdQuery
    {
        public GetServiceRequestByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }

    public class GetServiceRequestByIdQueryHandler : IGetServiceRequestByIdQueryHandler
    {
        public GetServiceRequestByIdQueryHandler()
        {
            
        }

        public async Task<ServiceRequest> GetServiceRequestById(GetServiceRequestByIdQuery query
            , CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
