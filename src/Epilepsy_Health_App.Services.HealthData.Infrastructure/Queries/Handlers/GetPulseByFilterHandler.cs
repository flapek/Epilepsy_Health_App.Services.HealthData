using Epilepsy_Health_App.Services.HealthData.Application.Dtos;
using Epilepsy_Health_App.Services.HealthData.Application.Queries;
using Epilepsy_Health_App.Services.HealthData.Application.Repositories;
using Joint.CQRS.Queries;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.HealthData.Infrastructure.Queries.Handlers
{
    public class GetPulseByFilterHandler : IQueryHandler<GetPulseByFilter, PulsesDto>
    {
        readonly IPulseRepository _pulseRepository;

        public GetPulseByFilterHandler(IPulseRepository pulseRepository)
            => _pulseRepository = pulseRepository;

        public async Task<PulsesDto> HandleAsync(GetPulseByFilter query)
            => await _pulseRepository.GetAsync(query.UserId, query.From, query.To);
    }
}
