using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vantage.Data;
using Vantage.Models;

namespace Vantage.Controllers
{
    public class HouseManagementController : Controller
    {
        // GET: HouseManagement or HouseManagement/Index
        public ActionResult Index()
        {
            // TODO: Make a home page for House Management
            //return View("HouseManagementHome");
            return new HttpStatusCodeResult(400, "Page not created yet");
        }

        // GET: HouseManagement/DutySheet
        public ActionResult DutySheet()
        {
            DutySheetViewModel viewModel = new DutySheetViewModel()
            {
                TestVar = "Hello, world!",
                TestList = HouseManagementData.GetTestList()
            };

            return View("DutySheet", viewModel);
        }

        public ActionResult HousePoints()
        {
            HousePointsViewModel viewModel = new HousePointsViewModel();
            return View("HousePoints", viewModel);
        }

        public ActionResult Fines()
        {
            FinesViewModel viewModel = new FinesViewModel();
            return View("Fines", viewModel);
        }
    }
}