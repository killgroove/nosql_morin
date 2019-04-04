using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nosql_morin.Controllers
{
    public class AlbumsController : Controller
    {
        // Instanciate AlbumsDao Queries (NOT INSIDE METHOD)
        
        // GET: Albums
        public ActionResult Index()
        {
            return View("Albums");
        }
    }
}