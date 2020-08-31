using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoPlacaPredictor.Tests.UI
{
    public class PACHome
    {
        #region Common
        /// <summary>
        /// Navegate to localhost web page
        /// </summary>
        public void NavegateToLocalWebApp(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:12769/");
            driver.Manage().Window.Size = new System.Drawing.Size(499, 728);
        }
        /// <summary>
        /// Submit page form
        /// </summary>
        public void SubmitPageForm(IWebDriver driver)
        {
            driver.FindElement(POMHome.submitInputButton).Click();
        }
        /// <summary>
        /// Clear home page
        /// </summary>
        public void ClearHomePage(IWebDriver driver)
        {
            driver.FindElement(POMHome.clearPageButton).Click();
        }
        #endregion Common

        #region InputFields
        /// <summary>
        /// Set value to input car plate
        /// </summary>
        /// <param name="value">value in string</param>
        public void SetValueCarPlate(IWebDriver driver, string value)
        {
            driver.FindElement(POMHome.carPlateInput).SendKeys(value);
        }
        /// <summary>
        /// Set value to input date travel
        /// </summary>
        /// <param name="value">value in string</param>
        public void SetValueDateTravel(IWebDriver driver, string value)
        {
            driver.FindElement(POMHome.dateTravelInput).SendKeys(value);
        }
        /// <summary>
        /// Set value to input time travel
        /// </summary>
        /// <param name="value">value in string</param>
        public void SetValueTimeTravel(IWebDriver driver, string value)
        {
            driver.FindElement(POMHome.timeTravelInput).SendKeys(value);
        }
        #endregion InputFields
        
        #region InputFieldsErrors
        /// <summary>
        /// Get error message from validation car plate field
        /// </summary>
        /// <param name="driver">Driver test</param>
        /// <returns>Error describe</returns>
        public string GetValueCarPlateError(IWebDriver driver)
        {
            return driver.FindElement(POMHome.carPlateError).Text;
        }
        /// <summary>
        /// Get error message from validation date travel field
        /// </summary>
        /// <param name="driver">Driver test</param>
        /// <returns>Error describe</returns>
        public string GetValueDateTravelError(IWebDriver driver)
        {
            return driver.FindElement(POMHome.dateTravelError).Text;
        }
        /// <summary>
        /// Get error message from validation time travel field
        /// </summary>
        /// <param name="driver">Driver test</param>
        /// <returns>Error describe</returns>
        public string GetValueTimeTravelError(IWebDriver driver)
        {
            return driver.FindElement(POMHome.timeTravelError).Text;
        }
        #endregion InputFieldsErrors

        #region ValidationPredictView
        /// <summary>
        /// Get text from title of validation view
        /// </summary>
        /// <param name="driver">Driver test</param>
        /// <returns>Validation title</returns>
        public string GetValidationPredictTitle(IWebDriver driver)
        {
            return driver.FindElement(POMHome.validationPredictTitle).Text;
        }
        /// <summary>
        /// Get text from describe validation view
        /// </summary>
        /// <param name="driver">Driver test</param>
        /// <returns>Validation describe</returns>
        public string GetValidationPredictDescription(IWebDriver driver)
        {
            return driver.FindElement(POMHome.validationPredictDescribe).Text;
        }
        #endregion ValidationPredictView

        #region ResultPredictView
        /// <summary>
        /// Get text from title or status predict result
        /// </summary>
        /// <param name="driver">Driver test</param>
        /// <returns>Result describe</returns>
        public string GetResultsPredictTitle(IWebDriver driver)
        {
            return driver.FindElement(POMHome.resultPredictTitle).Text;
        }
        /// <summary>
        /// Get text from title or status predict result
        /// </summary>
        /// <param name="driver">Driver test</param>
        /// <returns>Result describe</returns>
        public string GetResultsPredictDescription(IWebDriver driver)
        {
            return driver.FindElement(POMHome.resultPredictDescribe).Text;
        }
        /// <summary>
        /// Count all last digit restriction UL element
        /// </summary>
        /// <param name="driver">Driver test</param>
        /// <returns>Count of elements</returns>
        public int CountResultsPredictLastDigitsByDay(IWebDriver driver)
        {
            return driver.FindElements(POMHome.resultPredictLastDigits).Count;
        }
        /// <summary>
        /// Count ONE table predict table
        /// </summary>
        /// <param name="driver">Driver test</param>
        /// <returns>Count of elements</returns>
        public int CountResultsPredictTableInfo(IWebDriver driver)
        {
            return driver.FindElements(POMHome.resultPredictTableInfo).Count;
        }
        #endregion ResultPredictView
    }
}
