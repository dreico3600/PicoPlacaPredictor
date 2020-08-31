using PicoPlacaPredictor.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.Data.Models
{
    public class ResultPredictorModel
    {
        /// <summary>
        /// Code number state of the predictor
        /// 0: Has NO restrictions
        /// 1: Has No restriction because is weekend
        /// 2: HAS restrinction by time and day week 
        /// 3: HAS restrinction by day, but not in the time of travel
        /// </summary>
        public int CodeResult { get; set; }
        /// <summary>
        /// Hour restriction detail
        /// </summary>
        public RestrictedHours HourRestriction { get; set; }
        /// <summary>
        /// Row of data model Pico y Placa that match with the restriction datetime and last digit car's plate number
        /// </summary>
        public PicoPlacaModel PicoPlacaRestriction { get; set; }
    }
}
