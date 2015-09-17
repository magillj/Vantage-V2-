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
                Duties = HouseManagementData.GetDuties(),
                WeekDay = ConvertDayOfWeekToInt(DateTime.Now.DayOfWeek)
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

        // Converts the week day to a number used by the Duty Models
        private int ConvertDayOfWeekToInt(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday: return 0;
                case DayOfWeek.Monday: return 1;
                case DayOfWeek.Tuesday: return 2;
                case DayOfWeek.Wednesday: return 3;
                case DayOfWeek.Thursday: return 4;
                case DayOfWeek.Friday: return 5;
                case DayOfWeek.Saturday: return 6;
                default: throw new ArgumentException("Day of week invalid");
            }
        }
    }
}