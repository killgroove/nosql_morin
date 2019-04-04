using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nosql_morin.Controllers
{
    public class ArtistesController : Controller
    {
        // Instanciate ArtistesDao Queries (NOT INSIDE METHOD)

        // GET: Artistes
        public ActionResult Index()
        {
            return View("Artises");
        }
    }
}