using PicoPlacaPredictor.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PicoPlacaPredictor.Models
{
    public class OutputPredictResultModel
    {
        /// <summary>
        /// Result code get from prediction -->
        /// 0: Has NO restrictions
        /// 1: Has No restriction because is weekend
        /// 2: HAS restrinction by time and day week 
        /// 3: HAS restrinction by day, but not in the time of travel
        /// </summary>
        public int CodeResult { get; set; }
        /// <summary>
        /// Color of the result in Hexadecimal to apply in partial view title
        /// </summary>
        public string ColorHex { get; set; }
        /// <summary>
        /// The date and time travel joinned from the fields date and time input form
        /// </summary>
        public DateTime DateTimeTravel { get; set; }
        /// <summary>
        /// Last digit from car plate number
        /// </summary>
        public int LastDigitPlate { get; set; }
        /// <summary>
        /// State of result expresed as text, this field have relationship with code result field
        /// </summary>
        public string RestrictionTitle { get; set; }
        /// <summary>
        /// Message get in from the predictor based on code result field
        /// </summary>
        public string RestrictionMessage { get; set; }
        /// <summary>
        /// Details of "Pico y Placa" data row that match whit the last digit plate and datetime travel
        /// </summary>
        public PicoPlacaModel RestrictionDetails { get; set; }
    }
}