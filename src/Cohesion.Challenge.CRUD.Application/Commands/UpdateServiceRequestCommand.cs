﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Interfaces;
using Cohesion.Challenge.CRUD.Model.Enums;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Application.Commands
{
    public class UpdateServiceRequestCommand
    {
        public UpdateServiceRequestCommand(Guid id, string buildingCode,
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

        public Guid Id { get; }
        public string BuildingCode { get; }
        public string Description { get; }
        public CurrentStatus CurrentStatus { get; }
        public string CreatedBy { get; }
        public DateTime CreatedDate { get; }
        public string LastModifiedBy { get; }
        public DateTime LastModifiedDate { get; }
    }

    public class UpdateServiceRequestCommandHandler : IUpdateServiceRequestCommandHandler
    {
        private readonly IServiceRequestRepository _requestRepository;

        public UpdateServiceRequestCommandHandler(IServiceRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task UpdateServiceRequestById(UpdateServiceRequestCommand command
            , CancellationToken cancellationToken)
        {
            var service = new ServiceRequest(command.Id
                , command.BuildingCode
                , command.Description
                , command.CurrentStatus
                , command.CreatedBy
                , command.CreatedDate
                , command.LastModifiedBy
                , command.LastModifiedDate);

            await _requestRepository.UpdateServiceRequest(service, cancellationToken);
        }
    }
}
