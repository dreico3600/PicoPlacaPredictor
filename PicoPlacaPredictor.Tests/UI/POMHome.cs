using OpenQA.Selenium;

namespace PicoPlacaPredictor.Tests.UI
{
    public static class POMHome
    {
        //Input fields
        public static By carPlateInput = By.Id("carplate");
        public static By dateTravelInput = By.Id("datetravel");
        public static By timeTravelInput = By.Id("timetravel");
        //Input fields error span
        public static By carPlateError = By.Id("carplate-error");
        public static By dateTravelError = By.Id("datetravel-error");
        public static By timeTravelError = By.Id("timetravel-error");
        //Input buttons
        public static By submitInputButton = By.Id("inputSubmitValidate");
        public static By clearPageButton = By.Id("inputButtonClear");

        //Validation Predict fields
        public static By validationPredictTitle = By.CssSelector("#resultPredict > h4");
        public static By validationPredictDescribe = By.CssSelector("ul:nth-child(2) > li");

        //Results Predict fields
        public static By resultPredictTitle = By.CssSelector("h1");
        public static By resultPredictDescribe = By.CssSelector("#resultPredict p");
        public static By resultPredictLastDigits = By.Id("ul-lastdigits");
        public static By resultPredictTableInfo = By.Id("table-restrictioninfo");
    }
}
