using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Api.Contract.CreateServiceRequest;
using Cohesion.Challenge.CRUD.Api.Extensions;
using Cohesion.Challenge.CRUD.Application.Commands;
using Cohesion.Challenge.CRUD.Application.Queries;
using Cohesion.Challenge.CRUD.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cohesion.Challenge.CRUD.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceRequestController : ControllerBase
    {
        private readonly ICreateServiceRequestCommandHandler _createServiceRequest;
        private readonly IDeleteServiceRequestCommandHandler _deleteServiceRequest;
        private readonly IUpdateServiceRequestCommandHandler _updateServiceRequest;
        private readonly IGetAllServiceRequestQueryHandler _getAllServiceRequests;
        private readonly IGetServiceRequestByIdQueryHandler _getServiceRequest;

        public ServiceRequestController(ICreateServiceRequestCommandHandler createServiceRequest
            , IDeleteServiceRequestCommandHandler deleteServiceRequest
            , IUpdateServiceRequestCommandHandler updateServiceRequest
            , IGetAllServiceRequestQueryHandler getAllServiceRequest
            , IGetServiceRequestByIdQueryHandler getServiceRequest)
        {
            _createServiceRequest = createServiceRequest;
            _deleteServiceRequest = deleteServiceRequest;
            _updateServiceRequest = updateServiceRequest;
            _getAllServiceRequests = getAllServiceRequest;
            _getServiceRequest = getServiceRequest;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<ActionResult<IEnumerable<ServiceRequest>>> GetAllServiceRequests(CancellationToken cancellationToken)
        {
            var allServices = await _getAllServiceRequests.GetAllServiceRequests(cancellationToken);

            if (!allServices.Any())
                return NoContent();

            return Ok(allServices);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ServiceRequest>> GetServiceRequestById(string id, CancellationToken cancellationToken)
        {
            //Add Validation - To make sure is a valid GUID
            var query = id.ToQuery();
            var service = await _getServiceRequest.GetServiceRequestById(query, cancellationToken);

            if (service == null)
                return NotFound();

            return Ok(service);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> PostServiceRequest(CreateUpdateServiceRequestRequest request, CancellationToken cancellationToken)
        {
            //Add Validation - To make all fields are accurate
            var command = request.ToCommand();

            if (await _createServiceRequest.CreateServiceRequest(command, cancellationToken))
                return Created("created service request with id", request.Id);

            return BadRequest();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ServiceRequest>> PutServiceRequestById(string id, CreateUpdateServiceRequestRequest request,  CancellationToken cancellationToken)
        {
            try
            {
                //Add Validation - To make all fields are accurate
                var command = request.ToCommand(id);

                if (await _updateServiceRequest.UpdateServiceRequestById(command, cancellationToken))
                    return Ok("updated service request");
                
                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ServiceRequest>> DeleteServiceRequestById(string id, CancellationToken cancellationToken)
        {
            //Add Validation - To make all fields are accurate
            var command = id.ToCommand();

            if (await _deleteServiceRequest.DeleteServiceRequestById(command, cancellationToken))
                return Ok("successful");

            return NotFound();
        }
    }
}
