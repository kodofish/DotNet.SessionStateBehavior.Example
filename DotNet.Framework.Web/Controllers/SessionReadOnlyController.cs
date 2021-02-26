using System.Web.Mvc;
using System.Web.SessionState;

namespace DotNet.Framework.Web.Controllers
{
    [SessionState(SessionStateBehavior.ReadOnly)]
    public class SessionReadOnlyController : Controller
    {
        // GET
        public ActionResult Index()
        {
            if (Session["count"] == null)
                Session["count"] = 1;
            else
                Session["count"] = int.Parse(Session["count"].ToString()) + 1;
            
            return View();
        }
    }
}