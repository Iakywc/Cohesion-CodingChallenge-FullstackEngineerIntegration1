using System;
using Cohesion.Challenge.CRUD.Api.Contract.CreateServiceRequest;
using Cohesion.Challenge.CRUD.Application.Commands;
using Cohesion.Challenge.CRUD.Application.Queries;
using Cohesion.Challenge.CRUD.Model.Enums;

namespace Cohesion.Challenge.CRUD.Api.Extensions
{
    public static class ServiceRequestRequestMappingExtension
    {
        public static GetServiceRequestByIdQuery ToQuery(this string request)
        {
            return new GetServiceRequestByIdQuery(Guid.Parse(request));
        }

        public static CreateServiceRequestCommand ToCommand(this CreateUpdateServiceRequestRequest request)
        {
            return new CreateServiceRequestCommand(Guid.Parse(request.Id)
                , request.BuildingCode
                , request.Description
                , (CurrentStatus)Enum.Parse(typeof(CurrentStatus), request.CurrentStatus)
                , request.CreatedBy
                , request.CreatedDate
                , request.LastModifiedBy
                , request.LastModifiedDate);
        }

        public static UpdateServiceRequestCommand ToCommand(this CreateUpdateServiceRequestRequest request, string id)
        {
            return new UpdateServiceRequestCommand(Guid.Parse(id)
                , request.BuildingCode
                , request.Description
                , (CurrentStatus) Enum.Parse(typeof(CurrentStatus), request.CurrentStatus)
                , request.CreatedBy
                , request.CreatedDate
                , request.LastModifiedBy
                , request.LastModifiedDate);
        }

        public static DeleteServiceRequestCommand ToCommand(this string request)
        {
            return new DeleteServiceRequestCommand(Guid.Parse(request));
        }
    }
}
