using Microsoft.AspNetCore.SignalR;



namespace LMServer
{
    public class ChatHub : Hub
    {

        public async Task Send(MessageInfo message_info)
        {
            await Clients.All.SendAsync("Receive", message_info);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("Notify", $"{Context.ConnectionId} вошел в чат");
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            await Clients.All.SendAsync("Notify", $"{Context.ConnectionId} покинул в чат");
            await base.OnDisconnectedAsync(exception);
        }
    }
}
