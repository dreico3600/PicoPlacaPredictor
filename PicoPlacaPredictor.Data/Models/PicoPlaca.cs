using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.Data.Models
{
    public class PicoPlaca
    {
        public string DayName { get; set; }
        public List<int> LastDigitPlate { get; set; }
        public List<RestrictedHours> RestrictedHoursByDay { get; set; }
    }

    public class RestrictedHours
    {
        public string DayPart { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan Finish { get; set; }
    }
}
