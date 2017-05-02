using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarrierAPISandbox.Controllers
{
    public class FedExController : Controller
    {
        // GET: FedEx
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Track()
        {
            return View();
        }
    }
}