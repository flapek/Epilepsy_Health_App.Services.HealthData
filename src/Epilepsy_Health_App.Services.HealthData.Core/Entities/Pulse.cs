using System;

namespace Epilepsy_Health_App.Services.HealthData.Core.Entities
{
    public class Pulse
    {
        public DateTime CreatedAt { get; set; }
        public int Value { get; set; }

        public Pulse(DateTime createdAt, int value)
        {
            CreatedAt = createdAt;
            Value = value;
        }
    }
}
