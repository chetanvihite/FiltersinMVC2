

using System.Web.Mvc;
using IExceptionFilter = System.Web.Mvc.IExceptionFilter;
using FilterAttribute = System.Web.Mvc.FilterAttribute;

namespace FilterInMvc2.CustomFilters
{
    public class ExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            Utils.SessionManager.StoreInSession(filterContext, "OnException");
        }
    }
}