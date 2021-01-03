using Epilepsy_Health_App.Services.HealthData.Application.Dtos;
using Epilepsy_Health_App.Services.HealthData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Epilepsy_Health_App.Services.HealthData.Application.Repositories
{
    public interface IPulseRepository
    {
        Task<PulsesDto> GetAsync(Guid userId, DateTime? from = null, DateTime? to = null);
        Task AddAsync(Guid userId, IEnumerable<Pulse> pulses);
    }
}
