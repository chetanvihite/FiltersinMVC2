


using System.Web.Mvc;
using IAuthorizationFilter = System.Web.Mvc.IAuthorizationFilter;
using FilterAttribute = System.Web.Mvc.FilterAttribute;

namespace FilterInMvc2.CustomFilters
{
    public class AuthorizationFilter : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            Utils.SessionManager.StoreInSession(filterContext, "OnAuthorization");
        }
    }
}