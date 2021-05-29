using System;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Api.Contract.CreateServiceRequest;
using Cohesion.Challenge.CRUD.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cohesion.Challenge.CRUD.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceRequestController : ControllerBase
    {
        public ServiceRequestController()
        {
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ServiceRequest>> GetAllServiceRequests(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ServiceRequest>> GetServiceRequestById(string id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ServiceRequest>> PostServiceRequest(CreateUpdateServiceRequestRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ServiceRequest>> PutServiceRequestById(string id, CreateUpdateServiceRequestRequest request,  CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ServiceRequest>> DeleteServiceRequestById(string id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
