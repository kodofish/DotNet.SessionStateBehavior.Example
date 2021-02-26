using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using System.Web.Routing;

namespace DotNet.Framework.Web
{
    /// <summary>
    ///
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        [SuppressMessage("Usage", "CC0022")]
        public static void Register(HttpConfiguration config)
        {
            RouteTable.Routes.MapHttpRoute("DefaultApi"
                , "api/{controller}"
                , new {
                    controller = "SessionDefault"
                });
        }
    }
}
