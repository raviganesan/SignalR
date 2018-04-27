using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRNet
{
    public class RealTimeHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);

        }

        public void ConfigSettings(string param)
        {            
            Clients.All.addMessage("Server:" + param);
        }
    }
}