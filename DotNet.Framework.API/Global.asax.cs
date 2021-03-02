using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.SessionState;
using DotNet.Framework.Web;

namespace DotNet.Framework.API
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            
            HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Disabled);
        }
    }
}