using Microsoft.AspNetCore.SignalR;


namespace LMServer
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string username)
        {
            await this.Clients.All.SendAsync("Receive", message, username);
        }
    }
}
