using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.SignalR;
namespace ECommerce_Dashboard.Hubs
{
    public class NotificationHubs:Hub
    {
        
        [HubMethodName("NotifyClients")]
        public  void NotifyCurrentEmployeeInformationToAllClients()
        {
            // the update client method will update the connected client about any recent changes in the server data
           Clients.All.SendAsync("updatedClients");
        }
    }

}
