using PicoPlacaPredictor.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        /// <summary>
        /// Predictor function for Pico y Placa
        /// </summary>
        /// <param name="inputData">Fields inputs capture from Index page</param>
        /// <returns>Partial View with results</returns>
        [HttpPost]
        public ActionResult PredictPicoPlaca(InputDataFieldsModel inputData)
        {
            var result = new OutputPredictResultModel();

            if (ModelState.IsValid)
            {
                // Validate "pico y placa" restriction
                var datetimeTravel = Convert.ToDateTime(inputData.DateTravel + " " + inputData.TimeTravel);
                var timeTravel = datetimeTravel.TimeOfDay;
                var nameDay = datetimeTravel.DayOfWeek.ToString();
                var lastDigitPlate = Convert.ToInt32(inputData.CarPlate.Last().ToString());

                var resultPredict = new BLL.RestrictedCalendar().PredictPicoPlaca(timeTravel, nameDay, lastDigitPlate);

                // Prepare Model result
                result.CodeResult = resultPredict.CodeResult;
                result.RestrictionDetails = resultPredict.PicoPlacaRestriction;
                result.DateTimeTravel = datetimeTravel;
                result.LastDigitPlate = lastDigitPlate;
                result.ColorHex = ConfigurationManager.AppSettings[resultPredict.CodeResult + ":color"];
                result.RestrictionMessage = ConfigurationManager.AppSettings[resultPredict.CodeResult + ":message"];
                result.RestrictionTitle = ConfigurationManager.AppSettings[resultPredict.CodeResult + ":title"];

                // the message for result # 2 requires aditional information
                if (result.CodeResult == 2)
                {
                    result.RestrictionMessage = String.Format(result.RestrictionMessage,
                                                            resultPredict.HourRestriction.DayPart,
                                                            resultPredict.HourRestriction.Finish.ToString());
                }
                return PartialView("_PredictPicoPlaca", result);
            }
            else
                return PartialView("_ValidationSummaryDisplay", ViewData.ModelState);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}