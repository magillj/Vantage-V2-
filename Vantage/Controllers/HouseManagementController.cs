using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vantage.Controllers
{
    public class HouseManagementController : Controller
    {
        // GET: HouseManagement
        public ActionResult Index()
        {
            // TODO: Make a home page for House Management
            return View("HouseManagementHome");
        }

        public ActionResult Get(string id)
        {
            if (id.Equals("DutySheet"))
            {
                return View("DutySheet");
            }
        }
    }
}