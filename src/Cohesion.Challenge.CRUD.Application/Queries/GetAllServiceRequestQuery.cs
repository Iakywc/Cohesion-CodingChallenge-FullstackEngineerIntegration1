using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Interfaces;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Application.Queries
{
    public class GetAllServiceRequestQuery
    {
    }

    public class GetAllServiceRequestQueryHandler : IGetAllServiceRequestQueryHandler
    {
        private readonly IServiceRequestRepository _requestRepository;

        public GetAllServiceRequestQueryHandler(IServiceRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<IEnumerable<ServiceRequest>> GetAllServiceRequests(CancellationToken cancellationToken)
        {
            return await _requestRepository.GetAllSerivceRequest(cancellationToken);
        }
    }
}
