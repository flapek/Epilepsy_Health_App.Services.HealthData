using Epilepsy_Health_App.Services.HealthData.Application.Commands;
using Epilepsy_Health_App.Services.HealthData.Application.Controllers;
using Epilepsy_Health_App.Services.HealthData.Application.Dtos;
using Epilepsy_Health_App.Services.HealthData.Application.Queries;
using Joint.CQRS.Commands;
using Joint.CQRS.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        [ProducesResponseType(typeof(PulsesDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get([FromQuery] GetPulseByFilter filter)
        {
            filter.UserId = _claimsController.GetUserId(HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value);
            return Ok(await _queryDispatcher.QueryAsync(filter));
        }

        [HttpPost("data/add")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add(AddPulseData command)
        {
            command.UserId = _claimsController.GetUserId(HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "Authorization").Value);
            await _commandDispatcher.SendAsync(command);
            return Accepted();
        }


    }
}
