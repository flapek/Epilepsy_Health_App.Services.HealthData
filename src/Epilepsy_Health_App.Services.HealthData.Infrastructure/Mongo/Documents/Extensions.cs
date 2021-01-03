using Epilepsy_Health_App.Services.HealthData.Application.Dtos;
using Epilepsy_Health_App.Services.HealthData.Infrastructure.Mongo.Documents;
using System.Collections.Generic;
using System.Linq;

namespace Epilepsy_Health_App.Services.Identity.Infrastructure.Mongo.Documents
{
    internal static class Extensions
    {
        public static PulsesDto AsEntity(this IReadOnlyList<PulseDocument> pulseDocuments)
        {
            var result = new PulsesDto();

            pulseDocuments.Select(x => result.PulseDtos.Append(new PulseDto
            {
                CreatedAt = x.CreatedAt,
                Value = x.Value
            }));

            return result;
        }
    }
}
