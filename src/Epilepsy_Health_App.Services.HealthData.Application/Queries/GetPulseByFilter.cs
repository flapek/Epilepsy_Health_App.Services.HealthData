using Epilepsy_Health_App.Services.HealthData.Application.Dtos;
using Joint.CQRS.Queries;

namespace Epilepsy_Health_App.Services.HealthData.Application.Queries
{
    public class GetPulseByFilter : IQuery<PulsesDto>
    {
    }
}
