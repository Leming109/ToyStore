using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStore.Controllers
{
    public class ToyStoreController : Controller
    {
        // GET: ToyStore
        public ActionResult HomeView()
        {
            return View();
        }
    }
}