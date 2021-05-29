using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Application.Queries
{
    public class GetAllServiceRequestQuery
    {
    }

    public class GetAllServiceRequestQueryHandler : IGetAllServiceRequestQueryHandler
    {
        public GetAllServiceRequestQueryHandler()
        {
            
        }

        public async Task<IEnumerable<ServiceRequest>> GetAllServiceRequests(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
