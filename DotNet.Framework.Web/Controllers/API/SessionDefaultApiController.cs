using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.SessionState;
using log4net;

namespace DotNet.Framework.Web.Controllers.API
{
    [SessionState(SessionStateBehavior.Default)]
    public class SessionDefaultController : ApiController
    {
        private ILog Logger => LogManager.GetLogger(this.GetType());
        
        // GET
        public string Get()
        {
            Logger.Info("Start");

            var Session = HttpContext.Current.Session;
            if (Session["count"] == null)
                Session["count"] = 1;
            else
                Session["count"] = int.Parse(Session["count"].ToString()) + 1;
            Thread.Sleep(1000);
            Logger.Info("End");
            
            return "Success";
        }
    }
}