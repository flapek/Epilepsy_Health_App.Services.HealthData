using Epilepsy_Health_App.Services.HealthData.Application.Dtos;
using Epilepsy_Health_App.Services.HealthData.Application.Repositories;
using Epilepsy_Health_App.Services.HealthData.Core.Entities;
using Epilepsy_Health_App.Services.HealthData.Infrastructure.Mongo.Documents;
using Epilepsy_Health_App.Services.Identity.Infrastructure.Mongo.Documents;
using Joint.DB.Mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.HealthData.Infrastructure.Mongo.Repositories
{
    internal sealed class PulseRepository : IPulseRepository
    {
        private readonly IMongoRepository<PulseDocument, Guid> _repository;

        public PulseRepository(IMongoRepository<PulseDocument, Guid> repository)
            => _repository = repository;

        public async Task<PulsesDto> GetAsync(Guid userId, DateTime? from = null, DateTime? to = null) 
            => (await _repository
            .FindAsync(x => x.UserId == userId && (from.HasValue && to.HasValue)
            ? x.CreatedAt >= from.Value && x.CreatedAt <= to.Value
            : (from.HasValue && !to.HasValue
            ? x.CreatedAt >= from.Value
            : x.CreatedAt >= DateTime.UtcNow.AddDays(-7))))?.AsEntity();

        public Task AddAsync(Guid userId, IEnumerable<Pulse> pulses)
        {
            pulses.Select(x => _repository.AddAsync(new PulseDocument
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                CreatedAt = x.CreatedAt,
                Value = x.Value
            }));

            return Task.CompletedTask;
        }
    }
}
