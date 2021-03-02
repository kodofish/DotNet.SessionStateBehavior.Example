using System.Threading;
using System.Web;
using System.Web.Http;

namespace DotNet.Framework.API.Controllers
{
    public class SessionDefaultController : ApiController
    {
        // GET
        public string Get()
        {
            var session = HttpContext.Current.Session;

            if (session != null)
            {
                if (session["count"] == null)
                    session["count"] = 1;
                else 
                    session["count"] = int.Parse(session["count"].ToString()) + 1;
            }

            Thread.Sleep(1000);
            return "Success";
        }
    }
}