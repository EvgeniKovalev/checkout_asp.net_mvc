using System.Web.Mvc;
using System.Web.Routing;

namespace checkout_asp.net_mvc
{
  public class RouteConfig
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="routes"></param>
    public static void RegisterRoutes(RouteCollection routes)
    {
      routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      routes.MapRoute(
          name: "Default",
          url: "{controller}/{action}/{id}",
          defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional }
      );
    }
  }
}
