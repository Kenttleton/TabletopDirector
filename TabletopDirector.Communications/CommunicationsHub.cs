using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace TabletopDirector.Communications
{
    public class CommunicationsHub : Hub, IDisposable
    {
        private DbContext _db { get; set;}
        public CommunicationsHub(DbContext context)
        {
            if(_db == null)
            {
                _db = context;
            }
        }
        [Authorize("PlayerOrGM")]
        public void Connect(string username, string campaignId)
        {
            
        }
        [Authorize("PlayerOrGM")]
        public async Task AddToGroup(string campaignName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, campaignName);

            await Clients.Group(campaignName).SendAsync("Send", $"{Context.ConnectionId} has joined {campaignName}.");
        }
        [Authorize("GM")]
        public async Task KickFromCampaign(string username, string campaignName)
        {
            //var connections = Clients.All;
            //string userConnectionId;

            //foreach(var con in connections)
            //{
            //    con.
            //}
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, campaignName);

            await Clients.Group(campaignName).SendAsync("Send", $"{Context.ConnectionId} was kicked from {campaignName}.");
        }
        public void SendMessageToAll(string username, string campaignId, string message)
        {

        }

        public Task SendPrivateMessage(string user, string message)
        {
            return Clients.User(user).SendAsync("ReceiveMessage", message);
        }

        public Task OnDisconnected()
        {
            //this.
            //var item = ConnectedUsers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            //if (item != null)
            //{
            //    ConnectedUsers.Remove(item);

            //    var id = Context.ConnectionId;
            //    Clients.All.onUserDisconnected(id, item.UserName);

            //}

            //return base.OnDisconnected();
            return Task.CompletedTask;
        }
    }
}
