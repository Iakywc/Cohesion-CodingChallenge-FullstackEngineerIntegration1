using System;
using Cohesion.Challenge.CRUD.Model.Enums;

namespace Cohesion.Challenge.CRUD.Model.Models
{
    public class ServiceRequest
    {
        public ServiceRequest(Guid id, string buildingCode, string description, CurrentStatus currentStatus, string createdBy, DateTime createdDate, string lastModifiedBy, DateTime lastModifiedDate)
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

        public Guid Id { get; private set; }
        public string BuildingCode { get; private set; }
        public string Description { get; private set; }
        public CurrentStatus CurrentStatus { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string LastModifiedBy { get; private set; }
        public DateTime LastModifiedDate { get; private set; }
    }
}
