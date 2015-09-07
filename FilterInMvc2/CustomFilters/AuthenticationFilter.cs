



using System.Web.Mvc.Filters;
using FilterAttribute = System.Web.Mvc.FilterAttribute;

namespace FilterInMvc2.CustomFilters
{

    public class AuthenticationFilter : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            Utils.SessionManager.StoreInSession(filterContext, "OnAuthentication");
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            Utils.SessionManager.StoreInSession(filterContext, "OnAuthenticationChallenge");
        }

        
    }
}