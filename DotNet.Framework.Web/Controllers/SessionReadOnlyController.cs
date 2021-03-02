using System.Threading;
using System.Web.Mvc;
using System.Web.SessionState;
using log4net;

namespace DotNet.Framework.Web.Controllers
{
    [SessionState(SessionStateBehavior.ReadOnly)]
    public class SessionReadOnlyController : Controller
    {
        private ILog Logger => LogManager.GetLogger(this.GetType());
        
        // GET
        public ActionResult Index()
        {
            // if (Session["count"] == null)
            //     Session["count"] = 1;
            // else
            //     Session["count"] = int.Parse(Session["count"].ToString()) + 1;
            
            Logger.Info("Start");
            Thread.Sleep(1000);
            Logger.Info("End");
            return View();
        }
    }
}