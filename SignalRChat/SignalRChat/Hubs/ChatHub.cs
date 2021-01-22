using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

//https://docs.microsoft.com/en-gb/aspnet/core/tutorials/signalr?tabs=visual-studio&view=aspnetcore-5.0

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}