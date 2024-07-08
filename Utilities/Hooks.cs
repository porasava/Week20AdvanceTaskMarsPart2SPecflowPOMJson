using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Steps;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;
using BoDi;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.SIgnIn;
using System.IO;
using OpenQA.Selenium.Support.Extensions;
using System.Text.RegularExpressions;


[SetUpFixture]
public class GlobalReport
{
    public static ExtentReports extent;

    [OneTimeSetUp]
    public void Setup()
    {
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        string reportPath = projectDirectory + "//Reports/TestReport.html";
        // "TestData", "TestDataLogin.json"
        extent = new ExtentReports();
        var htmlReporter = new ExtentV3HtmlReporter(reportPath);
        extent.AttachReporter(htmlReporter);
        extent.AddSystemInfo("Host Name", "Local host");
        extent.AddSystemInfo("Website", "http://localhost:5001/Account/Profile");
        extent.AddSystemInfo("Environment", "QA");
        extent.AddSystemInfo("Username", "Tananya Asavaoran");

    }

    [OneTimeTearDown]
    public void Teardown()
    {
        extent.Flush();
    }
}



namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities
{
    [Binding]
    public class Hooks
    {

        protected IWebDriver driver1;
        protected PageLogin LoginPageObj;
        protected _001_StepPassword StepPasswordObj;
        protected _002_StepEducation StepEducationObj;
        protected _003_StepCertification StepCertificationObj;
        protected _004_StepDescription StepDescriptionObj;
        protected _005_StepManageListing StepManageListingObj;
        protected _006_StepManageRequest StepManageRequestObj;
        protected ExtentReports extent;
        protected ExtentTest test;
        


        //Add Specflow Json
        private readonly IObjectContainer _objectContainer;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        public class WebDriverSupport
        {
            public IWebDriver Driver { get; private set; }

            public WebDriverSupport()
            {
                // Initialize your WebDriver here (e.g., ChromeDriver)
                Driver = new ChromeDriver();
            }
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Initialize WebDriver here and register with SpecFlow's DI container
            IWebDriver webDriver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
            LoginPageObj = new PageLogin(driver1);
            StepPasswordObj = new _001_StepPassword(driver1);
            StepEducationObj = new _002_StepEducation(driver1);
            StepCertificationObj = new _003_StepCertification(driver1);
            StepDescriptionObj = new _004_StepDescription(driver1);
            StepManageListingObj = new _005_StepManageListing(driver1);
            StepManageRequestObj = new _006_StepManageRequest(driver1);
            //test = GlobalReport.extent.CreateTest(TestContext.CurrentContext.Test.Name);
            // Initialize a test instance for Extent Reports
            test = GlobalReport.extent.CreateTest(ScenarioContext.Current.ScenarioInfo.Title);
            ScenarioContext.Current["ExtentTest"] = test;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Retrieve and quit WebDriver
            var driver1 = _objectContainer.Resolve<IWebDriver>();

            var status = TestContext.CurrentContext.Result.Outcome.Status;
            // Generate log file
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;

            // Retrieve scenario name from SpecFlow context
            string scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            // Replace invalid characters for filenames
            scenarioTitle = Regex.Replace(scenarioTitle, "[^a-zA-Z0-9_]+", "_", RegexOptions.Compiled);

            DateTime time = DateTime.Now;
            string dateTimeFormat = time.ToString("yyyyMMddHHmmss");
            String fileName = $"{scenarioTitle}_{dateTimeFormat}.png";

            if (status == TestStatus.Failed)
            {
                test.Fail("Test failed", CaptureScreenshot(driver1, fileName));
                test.Log(Status.Fail, "test failed with logtrace" + stackTrace);
            }
            else if (status == TestStatus.Passed)
            {
                test.Pass("Test passed");
                test.Pass("Test passed", CaptureScreenshot(driver1, fileName));
            }
            else
            {
                test.Skip("Test skipped");
            }

            CommonDriver.CloseDriver(driver1);
            driver1.Quit();
        }
        //Finished add Specflow Json



        public MediaEntityModelProvider CaptureScreenshot(IWebDriver driver1, string screenshotName)
        {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName ?? string.Empty;
                string screenshotsDirectory = Path.Combine(projectDirectory, "Screenshots");
                if (!Directory.Exists(screenshotsDirectory))
                {
                    Directory.CreateDirectory(screenshotsDirectory);
                }

            string trimmedScreenshotName = screenshotName.Length > 13 ? screenshotName.Substring(0, 13) : screenshotName;
            // Append the current date and time to the filename
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string screenshotFileName = $"{trimmedScreenshotName}_{timestamp}.png";
            string screenshotFilePath = Path.Combine(screenshotsDirectory, screenshotFileName);

            // Take the screenshot
            ITakesScreenshot screenshotDriver = (ITakesScreenshot)driver1;
            Screenshot screenshot = screenshotDriver.GetScreenshot();

            // Save the screenshot to the specified path (PNG by default)
            screenshot.SaveAsFile(screenshotFilePath);

            // Create and return the media entity for reporting tools
            return MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotFilePath, screenshotName).Build();

        }
    }

}
