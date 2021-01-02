using Joint.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.HealthData.Application.Commands.Handlers
{
    public class AddPulseDataHandler : ICommandHandler<AddPulseData>
    {
        readonly IPulseRepository _pulseRepository;

        public AddPulseDataHandler(IPulseRepository pulseRepository) 
            => _pulseRepository = pulseRepository;

        public async Task HandleAsync(AddPulseData command)
        {
            await _pulseRepository.Add(command);
            throw new NotImplementedException();
        }
    }
}
