using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.Profile;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.SIgnIn;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Steps
{
    [Binding]
    public class _004_StepDescription
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _004_PageDescription PageDescriptionObj;
        private List<_004_ModelDescription> _ModelDescription;
        private readonly _004_ModelDescription DescriptionModel;
        private readonly ModelLogin LoginModel;
        private List<ModelLogin> _ModelLogin;

        public _004_StepDescription(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            PageDescriptionObj = new _004_PageDescription(driver1);
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);

            string jsonFilePathDescription = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "004_TestDataDescription.json");
            _ModelDescription = JsonReader.ReadDescriptionData(jsonFilePathDescription);
            LoginModel = _ModelLogin.FirstOrDefault();
        }

        private _004_ModelDescription GetCurrentTestData()
        {
            var currentTestCaseId = ScenarioContext.Current.ScenarioInfo.Tags.FirstOrDefault();
            var currentTestData = _ModelDescription.FirstOrDefault(cer => cer.TestCaseId == currentTestCaseId);

            if (currentTestData == null)
                throw new InvalidOperationException($"No test data found for TestCaseId: {currentTestCaseId}");

            return currentTestData;
        }


        [When(@"I edit the Description")]
        public void WhenIEditTheDescription()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageDescriptionObj.editDescription(currentTestData.Description);
        }

        [Then(@"The description should be edited successfully")]
        public void ThenTheDescriptionShouldBeEditedSuccessfully()
        {
            PageDescriptionObj.descriptionShouldBeEditSuccessfully();
        }

        [Then(@"I revert the Description back to itd original state")]
        public void ThenIRevertTheDescriptionBackToItdOriginalState()
        {
            var currentTestData = GetCurrentTestData();
            PageDescriptionObj.EditBackToTheOriginalDescription(currentTestData.OriginalDescription);
        }

    }
}
