using System;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Interfaces;
using Cohesion.Challenge.CRUD.Model.Enums;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Application.Commands
{
    public class CreateServiceRequestCommand
    {
        public CreateServiceRequestCommand(Guid id, string buildingCode, 
            string description, CurrentStatus currentStatus, string createdBy, 
            DateTime createdDate, string lastModifiedBy, DateTime lastModifiedDate)
        {
            Id = id;
            BuildingCode = buildingCode;
            Description = description;
            CurrentStatus = currentStatus;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            LastModifiedBy = lastModifiedBy;
            LastModifiedDate = lastModifiedDate;
        }

        public Guid Id { get;}
        public string BuildingCode { get; }
        public string Description { get; }
        public CurrentStatus CurrentStatus { get; }
        public string CreatedBy { get; }
        public DateTime CreatedDate { get; }
        public string LastModifiedBy { get; }
        public DateTime LastModifiedDate { get; }
    }

    public class CreateServiceRequestCommandHandler : ICreateServiceRequestCommandHandler
    {
        private readonly IServiceRequestRepository _requestRepository;

        public CreateServiceRequestCommandHandler(IServiceRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<bool> CreateServiceRequest(CreateServiceRequestCommand command,
            CancellationToken cancellationToken)
        {
            try
            {
                var service = new ServiceRequest(command.Id
                , command.BuildingCode
                , command.Description
                , command.CurrentStatus
                , command.CreatedBy
                , command.CreatedDate
                , command.LastModifiedBy
                , command.LastModifiedDate);

                await _requestRepository.CreateServiceRequest(service, cancellationToken);

                return true;
            }
            catch (Exception e)
            {
                //Log error and return result
                return false;
            }
        }
    }
}
