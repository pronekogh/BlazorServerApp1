//using Microsoft.AspNetCore.SignalR;

//namespace BlazorServerApp1
//{
//    public class ChatHub
//    {
//    }
//}
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
//namespace BlazorSignalRApp.Hubs
namespace BlazorServerApp1.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
