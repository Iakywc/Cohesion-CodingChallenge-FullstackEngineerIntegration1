using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Cohesion.Challenge.CRUD.Application.Interfaces;
using Cohesion.Challenge.CRUD.Model.Models;

namespace Cohesion.Challenge.CRUD.Repository.LocalServiceRequest
{
    public class ServiceRequestRepository : IServiceRequestRepository
    {
        public ServiceRequestRepository() { }

        public async Task<ServiceRequest> GetServiceRequestById(string id, CancellationToken cancellationToken)
        {
            await using FileStream openStream = File.OpenRead(string.Format(ConstantValues.LocalGenericFile, id));

            return await JsonSerializer.DeserializeAsync<ServiceRequest>(openStream, cancellationToken: cancellationToken);
        }

        public async Task<IEnumerable<ServiceRequest>> GetAllSerivceRequest(CancellationToken cancellationToken)
        {
            var serviceList = new List<ServiceRequest>();

            foreach (var file in Directory.GetFiles(string.Format(ConstantValues.LocalGenericFile, "*")))
            {
                await using FileStream openStream = File.OpenRead(file);

                serviceList.Add(await JsonSerializer.DeserializeAsync<ServiceRequest>(openStream, cancellationToken: cancellationToken));
            }

            return serviceList;
        }

        public async Task CreateServiceRequest(ServiceRequest service, CancellationToken cancellationToken)
        {
            await using FileStream createStream =
                File.Create(string.Format(ConstantValues.LocalGenericFile, service.Id.ToString()));

            await JsonSerializer.SerializeAsync(createStream, service, cancellationToken: cancellationToken);
        }

        public async Task UpdateServiceRequest(ServiceRequest service, CancellationToken cancellationToken)
        {
            await DeleteServiceRequest(service.Id.ToString(), cancellationToken);
            await CreateServiceRequest(service, cancellationToken);
        }

        public async Task DeleteServiceRequest(string id, CancellationToken cancellationToken)
        {
            await Task.Run(() => File.Delete(string.Format(ConstantValues.LocalGenericFile, id)), cancellationToken);
        }
    }
}
