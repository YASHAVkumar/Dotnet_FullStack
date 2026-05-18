using Microsoft.AspNetCore.SignalR;

namespace mvc_project.EMS.Web.Hubs;

public class NotificationHub : Hub
{
    public async Task SendMessage(string message)
    {
        await Clients.All.SendAsync(
            "ReceiveMessage",
            message);
    }
}