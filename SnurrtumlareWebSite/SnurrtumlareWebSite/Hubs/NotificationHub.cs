using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite
{
    public class NotificationHub : Hub
    {
        //temporary test message
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        //should eventually notify BO users when an order is created
        public async Task SendOrderNotification(int orderId, string firstName, string lastName, string message)
        {
            //change to the commented code once groups are working
            //await Clients.Group("BackOffice").SendAsync("ReceiveNotification", orderId, firstName, lastName, message);
            await Clients.All.SendAsync("ReceiveNotification", orderId, firstName, lastName, message);
        }
    }
}
