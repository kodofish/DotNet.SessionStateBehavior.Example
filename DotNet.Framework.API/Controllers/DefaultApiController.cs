using System.Threading;
using System.Web.Http;

namespace DotNet.Framework.API.Controllers
{
    public class SessionDefaultController : ApiController
    {
        // GET
        public string Get()
        {
            Thread.Sleep(1000);
            return "Success";
        }
    }
}