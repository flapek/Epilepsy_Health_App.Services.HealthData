using Epilepsy_Health_App.Services.HealthData.Core.Entities;
using Joint.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Epilepsy_Health_App.Services.HealthData.Application.Commands
{
    public class AddPulseData : ICommand
    {
        [JsonIgnore]
        public Guid UserId { get; set; }
        public IEnumerable<Pulse> PulseData { get; set; }
    }
}
