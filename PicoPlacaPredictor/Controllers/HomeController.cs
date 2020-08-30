using PicoPlacaPredictor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PicoPlacaPredictor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PredictPicoPlaca(InputDataFieldsModel inputData)
        {
            if (ModelState.IsValid)
            {
                var datetimeTravel = Convert.ToDateTime(inputData.DateTravel + " " + inputData.TimeTravel);

            }
            
            return PartialView("PredictPicoPlaca");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}