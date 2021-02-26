using System.Threading;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.SessionState;
using log4net;

namespace DotNet.Framework.Web.Controllers.API
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class SessionDisableController : ApiController
    {
        private ILog Logger => LogManager.GetLogger(this.GetType());
        // GET
        public string Get()
        {
            Logger.Info("Start");
            Thread.Sleep(1000);
            Logger.Info("End");
            return "Success!!";
        }
    }
}