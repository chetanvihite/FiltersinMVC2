

using System;
using System.Web.Mvc;

namespace FilterInMvc2.Utils
{
    public class SessionManager
    {
        public static void StoreInSession(ControllerContext context, string methodName)
        {
            if (context.HttpContext.Session == null) return;

            var sessionVal = context.HttpContext.Session["filter"];
            sessionVal = sessionVal + string.Format("<br> {0} : {1}", methodName, DateTime.Now.ToLongTimeString());
            context.HttpContext.Session["filter"] = sessionVal;
        }
    }
}