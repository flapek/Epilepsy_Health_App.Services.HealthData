using System;
using System.Collections.Generic;

namespace Epilepsy_Health_App.Services.HealthData.Application.Dtos
{
    public class PulsesDto
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public IEnumerable<PulseDto> PulseDtos { get; set; }
    }
}
