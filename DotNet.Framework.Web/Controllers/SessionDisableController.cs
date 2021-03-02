using System.Threading;
using System.Web.Mvc;
using System.Web.SessionState;
using log4net;

namespace DotNet.Framework.Web.Controllers
{
    
    [SessionState(SessionStateBehavior.Disabled)]
    public class SessionDisableController : Controller
    {
        private ILog Logger => LogManager.GetLogger(this.GetType());
        // GET
        public ActionResult Index()
        {
            Logger.Info("Start");
            Thread.Sleep(1000);
            Logger.Info("End");
            return View();
        }
    }
}