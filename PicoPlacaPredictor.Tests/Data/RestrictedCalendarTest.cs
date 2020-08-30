using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PicoPlacaPredictor.Data;
using PicoPlacaPredictor.Data.Models;

namespace PicoPlacaPredictor.Tests.Data
{
    [TestClass]
    public class RestrictedCalendarTest
    {
        [TestMethod]
        public void ListPicoPlaca()
        {
            // Arrange
            RestrictedCalendar restrictedCalendar = new RestrictedCalendar();

            // Act
            List<PicoPlaca> result = restrictedCalendar.ListPicoPlaca();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
