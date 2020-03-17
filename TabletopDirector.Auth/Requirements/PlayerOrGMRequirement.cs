using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TabletopDirector.Auth.Requirements
{
    public class PlayerOrGMRequirement : AuthorizationHandler<PlayerOrGMRequirement, Hub>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PlayerOrGMRequirement requirement, Hub resource)
        {
            //if (IsUserAllowedToDoThis(resource.HubMethodName, context.User.Identity.Name) &&
            //context.User.Identity.Name.EndsWith("@microsoft.com"))
            //{
            //    context.Succeed(requirement);
            //}
            return Task.CompletedTask;
        }
        private bool IsUserAllowedToDoThis(string hubMethodName, string currentUsername)
        {
            return !(currentUsername.Equals("asdf42@microsoft.com") &&
                hubMethodName.Equals("kickFromCampaign", StringComparison.OrdinalIgnoreCase));
        }
    }
}
