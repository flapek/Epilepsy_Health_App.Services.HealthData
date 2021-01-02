using Epilepsy_Health_App.Services.HealthData.Application.Dtos;
using Epilepsy_Health_App.Services.HealthData.Application.Repositories;
using Epilepsy_Health_App.Services.HealthData.Core.Entities;
using Epilepsy_Health_App.Services.HealthData.Infrastructure.Mongo.Documents;
using Epilepsy_Health_App.Services.Identity.Infrastructure.Mongo.Documents;
using Joint.DB.Mongo;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace Epilepsy_Health_App.Services.HealthData.Infrastructure.Mongo.Repositories
{
    internal sealed class PulseRepository : IPulseRepository
    {
        private readonly IMongoRepository<PulseDocument, Guid> _repository;

        public PulseRepository(IMongoRepository<PulseDocument, Guid> repository)
            => _repository = repository;

        public async Task<PulsesDto> GetAsync(IFilter filter)
        {
            return (await _repository.FindAsync(x => true))?.AsEntity();
        }

        public Task AddAsync(Guid userId, IEnumerable<Pulse> pulses)
        {
            throw new NotImplementedException();
        }
    }
}
