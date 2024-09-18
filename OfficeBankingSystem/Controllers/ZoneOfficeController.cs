using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OfficeBankingSystem.Controllers
{
    public class ZoneOfficeController : Controller
    {
        // GET: ZoneOffice
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
         
            return View();
        }
    }
}