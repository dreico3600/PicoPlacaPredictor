using Newtonsoft.Json;
using PicoPlacaPredictor.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.Data
{
    public class RestrictedCalendar
    {
        private List<PicoPlaca> _listRestrictedPicoPlaca;
        public RestrictedCalendar()
        {
            List<PicoPlaca> items;
            // Read json file in folder Json in this project
            using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + @"/Json/PicoPlaca.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<PicoPlaca>>(json);
            }
            // Save deserialize json into private variable
            _listRestrictedPicoPlaca = items;
        }

        public List<PicoPlaca> ListPicoPlaca()
        {
            return _listRestrictedPicoPlaca;
        }
        public bool PredictPicoPlaca(TimeSpan time, string dayName, int lastDigitPlate)
        {
            return true;
        }
    }
}
