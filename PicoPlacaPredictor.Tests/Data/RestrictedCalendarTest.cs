using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PicoPlacaPredictor.BLL;
using PicoPlacaPredictor.BLL.Models;

namespace PicoPlacaPredictor.Tests.Data
{
    [TestClass]
    public class RestrictedCalendarTest
    {
        /// <summary>
        /// Validate populate List of Pico y Placa function
        /// </summary>
        [TestMethod]
        public void ListPicoPlaca()
        {
            // Arrange
            RestrictedCalendar restrictedCalendar = new RestrictedCalendar();

            // Act
            List<PicoPlacaModel> result = restrictedCalendar.ListPicoPlaca();

            // Assert
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Validate predictor function with several samples
        /// </summary>
        /// <param name="hourTravel">hour of travel in 24h format</param>
        /// <param name="minuteTravel">minute of travel</param>
        /// <param name="dayName">Weekday name in english</param>
        /// <param name="lastDigitPlate">Last digit from car's plate number</param>
        /// <param name="expectedResult">Expecte result estimate from desktop test</param>
        [TestMethod]
        [DataTestMethod]
        [DataRow(11, 20, "monday", 2, 3)]
        [DataRow(11, 20, "monday", 3, 0)]
        [DataRow(9, 20, "tuesday", 4, 2)]
        [DataRow(9, 20, "thursday", 7, 2)]
        [DataRow(17, 20, "wednesday", 6, 2)]
        [DataRow(15, 20, "friday", 0, 3)]
        [DataRow(16, 20, "friday", 0, 2)]
        [DataRow(12, 20, "sunday", 3, 1)]
        public void PredictPicoPlaca(int hourTravel, int minuteTravel, string dayName, int lastDigitPlate,int expectedResult)
        {
            // Arrange
            RestrictedCalendar restrictedCalendar = new RestrictedCalendar();

            // Act
            var realResult = restrictedCalendar.PredictPicoPlaca(new TimeSpan(hourTravel,minuteTravel,0),dayName,lastDigitPlate);

            // Assert
            Assert.AreEqual(expectedResult,realResult.CodeResult,"El resultado esperado es: "+expectedResult+", y el real fue: "+realResult.CodeResult);
        }        
    }
}
