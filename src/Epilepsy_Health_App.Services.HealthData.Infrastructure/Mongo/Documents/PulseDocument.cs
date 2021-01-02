using Joint.Types;
using System;

namespace Epilepsy_Health_App.Services.HealthData.Infrastructure.Mongo.Documents
{
    public class PulseDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Value { get; set; }
    }
}
