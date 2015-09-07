

using System.Web.Mvc;
using FilterAttribute = System.Web.Mvc.FilterAttribute;

namespace FilterInMvc2.CustomFilters
{
    public class ResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Utils.SessionManager.StoreInSession(filterContext, "OnResultExecuting");
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Utils.SessionManager.StoreInSession(filterContext, "OnResultExecuted");
        }
    }
}