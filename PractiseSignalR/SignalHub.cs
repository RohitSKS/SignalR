using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace PractiseSignalR
{
    public class SignalHub:Hub
    {
        public void Announce(string user, string message)
        {
            Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        //https://codeopinion.com/practical-asp-net-core-signalr-server-hubs/
    }

}
