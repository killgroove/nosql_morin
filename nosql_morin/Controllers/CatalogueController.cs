using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nosql_morin.Controllers
{
    public class CatalogueController : Controller
    {
        // Instanciate CatalogueDao Queries (NOT INSIDE METHOD)

        // GET: Catalogue
        public ActionResult Index()
        {
            return View("Catalogue");
        }
    }
}