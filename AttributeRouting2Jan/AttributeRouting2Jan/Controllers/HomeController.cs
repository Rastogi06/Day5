using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting2Jan.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        //Using Attribute routing on Index Action method
        [Route ("Home/{id?}")]
        public ActionResult Index()
        {
            return View();
        }
    }
}