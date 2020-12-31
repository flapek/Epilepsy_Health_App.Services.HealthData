using Epilepsy_Health_App.Services.HealthData.Application.Dtos;
using Joint.CQRS.Queries;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Epilepsy_Health_App.Services.HealthData.Application.Queries
{
    public class GetPulseByFilter : IQuery<PulsesDto>
    {
        [JsonIgnore]
        public Guid UserId { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime From { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime To { get; set; } = DateTime.UtcNow;

    }
}
