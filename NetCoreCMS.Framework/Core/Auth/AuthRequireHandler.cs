﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreCMS.Framework.Core.Auth
{
    public class AuthRequireHandler : AuthorizationHandler<AuthRequire>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthRequire requirement)
        {
            if (!context.User.Identity.IsAuthenticated || !context.User.HasClaim(c => c.Type == ClaimTypes.Role ) )
            {
                // .NET 4.x -> return Task.FromResult(0);
                return Task.CompletedTask;
            }

            var isSameUser = true;
            var hasRole = true;
            
            if (!string.IsNullOrEmpty(requirement.User))
            {
                isSameUser = context.User.Identity.Name == requirement.User;
            }

            if (!string.IsNullOrEmpty(requirement.Role))
            {
                hasRole = context.User.IsInRole(requirement.Role);
            }

            if (isSameUser && hasRole )
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
