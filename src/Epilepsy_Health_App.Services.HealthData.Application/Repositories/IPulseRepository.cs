using Epilepsy_Health_App.Services.HealthData.Application.Dtos;
using Epilepsy_Health_App.Services.HealthData.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace Epilepsy_Health_App.Services.HealthData.Application.Repositories
{
    public interface IPulseRepository
    {
        Task Add(Guid userId, IEnumerable<Pulse> pulses);
        Task<PulsesDto> Get(IFilter filter);
    }
}
