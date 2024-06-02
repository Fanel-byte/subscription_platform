using BlazorApp.Models;
using Microsoft.AspNetCore.SignalR;

public class EventHub : Hub
{
    public async Task SendEvent(EventDetails eventDetails)
    {
        await Clients.All.SendAsync("ReceiveEvent", eventDetails);
    }
}
