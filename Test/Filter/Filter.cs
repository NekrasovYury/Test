using NLog;
using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web.Mvc;

namespace Test.Filter
{
    public class Filter : ActionFilterAttribute
    {
        
          private static Logger logger = LogManager.GetCurrentClassLogger();
          public override void OnActionExecuting(ActionExecutingContext actionContext)
         {
            var user = (actionContext.Controller as Controller)?.User as ClaimsPrincipal;
            var id = user.Claims.FirstOrDefault(i => i.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;
            if (id != null)

                // logger.SetProperty("UserId",);
                logger.SetProperty("controller", actionContext.ActionDescriptor.ControllerDescriptor.ControllerName);
            logger.SetProperty("Action", actionContext.ActionDescriptor.ActionName);
            logger.Info(Environment.NewLine + DateTime.Now);
            logger.SetProperty("CorrealactionId", null);
            logger.SetProperty("UserId", id);
        }
    
    }
}