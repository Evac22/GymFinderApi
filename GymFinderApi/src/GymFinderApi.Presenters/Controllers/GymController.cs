using GymFinderApi.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GymFinderApi.Presenters.Controllers;

[ApiController]
[Route("[controller]")]
public class GymController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateGymDTO request)
    {
        return Ok("Gym created");
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetGymDto request)
    {
        return Ok("All gyms in Kiev");
    }

    [HttpGet("{gymId:guid}")]
    public async Task<IActionResult> GetById([FromRoute] Guid gymId, CancellationToken cancellationToken)
    {
        return Ok("Gym with id 1");
    }

    [HttpPut("{gymId:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid gymId, [FromBody] UpdateGymDto request, CancellationToken cancellationToken)
    {
        return Ok("Gym updated");
    }

    [HttpDelete("{gymId:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid gymId, CancellationToken cancellationToken)
        {
            return Ok("Gym deleted");
    }
}
