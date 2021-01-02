using Epilepsy_Health_App.Services.HealthData.Application.Repositories;
using Joint.CQRS.Commands;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.HealthData.Application.Commands.Handlers
{
    public class AddPulseDataHandler : ICommandHandler<AddPulseData>
    {
        readonly IPulseRepository _pulseRepository;

        public AddPulseDataHandler(IPulseRepository pulseRepository) 
            => _pulseRepository = pulseRepository;

        public async Task HandleAsync(AddPulseData command) 
            => await _pulseRepository.AddAsync(command.UserId, command.PulseData);
    }
}
