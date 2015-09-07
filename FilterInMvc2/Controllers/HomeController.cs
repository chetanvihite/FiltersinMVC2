using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilterInMvc2.CustomFilters;

namespace FilterInMvc2.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }
	}

    
}