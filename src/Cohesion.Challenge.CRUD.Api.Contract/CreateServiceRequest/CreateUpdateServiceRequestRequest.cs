using System;

namespace Cohesion.Challenge.CRUD.Api.Contract.CreateServiceRequest
{
    /*
     * Since Update passes the id in the request I'd like to split this class.
     * If I do that now, request won't work. So leave as is until discuss with Business.
     */
    public class CreateUpdateServiceRequestRequest
    {
        public string Id { get; private set; }
        public string BuildingCode { get; private set; }
        public string Description { get; private set; }
        public string CurrentStatus { get; private set; }
        public string CreatedBy { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public string LastModifiedBy { get; private set; }
        public DateTime LastModifiedDate { get; private set; }
    }
}
