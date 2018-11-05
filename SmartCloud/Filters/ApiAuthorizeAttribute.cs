using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using SmartCloud.Common.Constants;
using SmartCloud.Services.Interfaces;

namespace SmartCloud.Filters
{
    public class ApiAuthorizeAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting (ActionExecutingContext context)
        {
            var accountService = context.HttpContext.RequestServices.GetService<IAccountService>();
            var sessionId = context.HttpContext.Request.Headers[SecurityConstants.ApiSessionId];
            if (!accountService.IsValidSessionId(sessionId))
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                context.Result = new JsonResult("Unauthorized");
            }
        }
    }
}