using Newtonsoft.Json;
using PicoPlacaPredictor.BLL.Models;
using PicoPlacaPredictor.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.BLL
{
    public class RestrictedCalendar
    {
        private const string _urlJsonData = "https://raw.githubusercontent.com/dreico3600/pico-y-placa-quito-json/master/PicoPlaca.json";
        private List<PicoPlacaModel> _listRestrictedPicoPlaca;

        /// <summary>
        /// Constructor for the class
        /// </summary>
        public RestrictedCalendar()
        {
            // Fill _list internal with data model Pico y Placa
            List<PicoPlacaModel> items;
            
            // Read json file in folder Json in this project
            using (StreamReader r = new StreamReader(WebRequest.Create(_urlJsonData).GetResponse().GetResponseStream()))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<PicoPlacaModel>>(json);
            }
            // Save deserialize json into private variable
            _listRestrictedPicoPlaca = items;
        }

        /// <summary>
        /// List of data for pico y placa
        /// </summary>
        /// <returns>list of data</returns>
        public List<PicoPlacaModel> ListPicoPlaca()
        {
            return _listRestrictedPicoPlaca;
        }

        /// <summary>
        /// Validate if a plate has restriction to drive
        /// </summary>
        /// <param name="timeTravel">Timespan to validate restriction</param>
        /// <param name="dayName">Day name to validate</param>
        /// <param name="lastDigitPlate">Las digit plate number to validate</param>
        /// <returns>0: Has NO restrictions; 1: Has No restriction because is weekend; 2: HAS restrinction by time and day week; 3: HAS restrinction by day, but not in the time of travel</returns>
        public ResultPredictorModel PredictPicoPlaca(TimeSpan timeTravel, string dayName, int lastDigitPlate)
        {
            ResultPredictorModel result = new ResultPredictorModel { CodeResult = 0};

            // 1. Validate day of week
            var dayWeek = _listRestrictedPicoPlaca.FirstOrDefault(r => r.DayName.ToUpper() == dayName.ToUpper());
            if (dayWeek is null)
            {
                result.CodeResult = 1;
            }
            else
            {
                // 2. Validate last digit number plate has restriction in the day
                var restrictedPlate = dayWeek.LastDigitPlate.Contains(lastDigitPlate);
                if (restrictedPlate)
                {
                    // Capture the PicoPlacaModel object match
                    result.PicoPlacaRestriction = dayWeek;

                    // 3. Validate if time of travel it's in some part of restricted hour
                    var restrictedHour = dayWeek.RestrictedHoursByDay.FirstOrDefault(r => r.Start <= timeTravel && timeTravel <= r.Finish);
                    if (restrictedHour is null)
                        result.CodeResult = 3;
                    else
                    {
                        // Capture the RestrictedHour object matc
                        result.HourRestriction = restrictedHour;
                        result.CodeResult = 2;
                    }
                }
            }

            return result;
        }
    }
}
