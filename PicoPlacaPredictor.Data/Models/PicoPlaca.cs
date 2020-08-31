using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.BLL.Models
{
    /// <summary>
    /// Data model for Pico y Placa restriction
    /// </summary>
    public class PicoPlacaModel
    {
        /// <summary>
        /// Name of the weekday
        /// </summary>
        public string DayName { get; set; }
        /// <summary>
        /// Last digit from the car's plate
        /// </summary>
        public List<int> LastDigitPlate { get; set; }
        /// <summary>
        /// List of the restricted hours in this day
        /// </summary>
        public List<RestrictedHours> RestrictedHoursByDay { get; set; }
    }

    public class RestrictedHours
    {
        /// <summary>
        /// Morning or Afternoon
        /// </summary>
        public string DayPart { get; set; }
        /// <summary>
        /// Start time of the restriction
        /// </summary>
        public TimeSpan Start { get; set; }
        /// <summary>
        /// Finish time of the restriction
        /// </summary>
        public TimeSpan Finish { get; set; }
    }
}
