using Epilepsy_Health_App.Services.HealthData.Application.Controllers;
using Joint.CQRS.Commands;
using Joint.CQRS.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Epilepsy_Health_App.Services.HealthData.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PulseController : ControllerBase
    {
        readonly IQueryDispatcher _queryDispatcher;
        readonly ICommandDispatcher _commandDispatcher;
        readonly IClaimsController _claimsController;

        public PulseController(IQueryDispatcher queryDispatcher,
            ICommandDispatcher commandDispatcher, IClaimsController claimsController)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
            _claimsController = claimsController;
        }
    }
}
