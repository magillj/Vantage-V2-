using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vantage.Data;
using Vantage.Models;

namespace Vantage.Controllers
{
    public class InfoController : Controller
    {

        // GET: Info or Info/Index
        public ActionResult Index()
        {
            // TODO: Make a home page for Information
            //return View("InformationHome");
            return new HttpStatusCodeResult(400, "Page not created yet");
        }

        // GET: Information/Directory
        public ActionResult Directory()
        {
            DirectoryViewModel viewModel = new DirectoryViewModel()
            {
                TestVar = "Hello, world!",
                Members = InformationData.GetMembers()
            };
            return View("Directory", viewModel);
        }

        public ActionResult MessageBoard()
        {
            MessageBoardModel model = new MessageBoardModel();
            return View("MessageBoard", model);
        }
    }
}