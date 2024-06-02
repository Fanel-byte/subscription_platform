using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using BlazorApp.Models;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class EventsController : ControllerBase
{
    private readonly IHubContext<EventHub> _hubContext;

    public EventsController(IHubContext<EventHub> hubContext)
    {
        _hubContext = hubContext;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] EventDetails eventData)
    {
        await _hubContext.Clients.All.SendAsync("ReceiveEvent", eventData);
        return Ok("success");
    }
}
