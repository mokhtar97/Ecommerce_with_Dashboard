using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

using Microsoft.AspNetCore.SignalR;
namespace ECommerce_Dashboard.Hubs
{



    public class ChatHub : Microsoft.AspNetCore.SignalR.Hub
    {

       
        public async Task SendMessage(string user, string message)
            {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            }


        [HubMethodName("broadcastData")]
        public async Task BroadcastDataAsync()
        {
            // IHubContext context = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            // context.Clients.All.updatedData();
            await Clients.All.SendAsync("updatedData");
        }
    }




}
