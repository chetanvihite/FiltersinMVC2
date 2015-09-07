

using System.Web.Mvc;
using FilterAttribute = System.Web.Mvc.FilterAttribute;
using IActionFilter = System.Web.Mvc.IActionFilter;

namespace FilterInMvc2.CustomFilters
{
    public class ActionFilter : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Utils.SessionManager.StoreInSession(filterContext, "OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Utils.SessionManager.StoreInSession(filterContext, "OnActionExecuted");
        }
    }
}