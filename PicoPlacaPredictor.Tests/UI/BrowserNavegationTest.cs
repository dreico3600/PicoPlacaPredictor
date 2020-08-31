using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox; 

namespace PicoPlacaPredictor.Tests.UI
{
    [TestClass]
    public partial class BrowserNavegationTest
    {
        protected IWebDriver driver;
        private Process _iisProcess;
        const int _iisPort = 12769;

        [TestInitialize]
        public void TestInitialize()
        {            
            // Start IISExpress
            StartIIS();
            // Setup the driver
            driver = new FirefoxDriver();
        }
        private void StartIIS()
        {
            // Obtain application path
            var applicationPath = GetApplicationPath("PicoPlacaPredictor");
            var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

            // create instance of IIS
            _iisProcess = new Process();
            // Set Path of instalation ISSExpress in the machine
            _iisProcess.StartInfo.FileName = $@"{programFiles}\IIS Express\iisexpress.exe";
            // set the application path to atach the ISS and the port
            _iisProcess.StartInfo.Arguments = $" /path:{applicationPath} /port:{_iisPort}";
            // Start the IIS
            _iisProcess.Start();
        }
        protected virtual string GetApplicationPath(string applicationName)
        {
            var solutionFolder = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)));
            return Path.Combine(solutionFolder, applicationName);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Ensure IISExpress is stopped
            if (_iisProcess.HasExited == false)
            {
                _iisProcess.Kill();
            }

            // Close driver
            driver.Quit();
        }
    }
}
