using System;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Interfaces;
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
        private readonly IServiceRequestRepository _requestRepository;
        public GetServiceRequestByIdQueryHandler(IServiceRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<ServiceRequest> GetServiceRequestById(GetServiceRequestByIdQuery query
            , CancellationToken cancellationToken)
        {
            return await _requestRepository.GetServiceRequestById(query.Id.ToString(), cancellationToken);
        }
    }
}
