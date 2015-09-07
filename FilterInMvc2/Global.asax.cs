

using System.Web.Mvc;
using System.Web.Routing;
using FilterInMvc2.CustomFilters;

namespace FilterInMvc2
{
   
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // registering filters at a global level 
            GlobalFilters.Filters.Add(new AuthenticationFilter());
            GlobalFilters.Filters.Add(new AuthorizationFilter());
            GlobalFilters.Filters.Add(new ActionFilter());
            GlobalFilters.Filters.Add(new ResultFilter());
            GlobalFilters.Filters.Add(new ExceptionFilter());

            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
