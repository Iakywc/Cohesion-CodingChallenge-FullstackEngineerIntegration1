using System;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Model.Enums;

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
        public CreateServiceRequestCommandHandler()
        {
            
        }

        public async Task<bool> CreateServiceRequest(CreateServiceRequestCommand command,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
