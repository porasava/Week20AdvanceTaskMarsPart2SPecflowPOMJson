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
    public class _003_StepCertification
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _003_PageCertification PageCertificationObj;
        private List<ModelLogin> _ModelLogin;
        private List<_003_ModelCertification> _ModelCertification;
        private readonly _003_ModelCertification CertificationModel;
        private readonly ModelLogin LoginModel;

        public _003_StepCertification(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            PageCertificationObj = new _003_PageCertification(driver1);
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);

            string jsonFilePathCertification = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "003_TestDataCertification.json");
            _ModelCertification = JsonReader.ReadCertificationData(jsonFilePathCertification);
            LoginModel = _ModelLogin.FirstOrDefault();
        }
        private _003_ModelCertification GetCurrentTestData()
        {
            var currentTestCaseId = ScenarioContext.Current.ScenarioInfo.Tags.FirstOrDefault();
            var currentTestData = _ModelCertification.FirstOrDefault(cer => cer.TestCaseId == currentTestCaseId);

            if (currentTestData == null)
                throw new InvalidOperationException($"No test data found for TestCaseId: {currentTestCaseId}");

            return currentTestData;
        }

        [Given(@"I have checked existing Certification entries")]
        public void GivenIHaveCheckedExistingCertificationEntries()
        {
            PageCertificationObj.GoToCertificationTab();
            PageCertificationObj.CheckExistingCertification();
        }

        [When(@"I have add new certification")]
        public void WhenIHaveAddNewCertification()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageCertificationObj.AddANewCertification(currentTestData.certificationName, currentTestData.certificationFrom, currentTestData.CertificationYear);
        }

        [Then(@"Pop up should be add successfully")]
        public void ThenPopUpShouldBeAddSuccessfully()
        {
            PageCertificationObj.CertificationShouldBeAddSuccessfully();
        }

        [Then(@"I have Delete a certification")]
        public void ThenIHaveDeleteACertification()
        {
            PageCertificationObj.DeleteACertificationNoCheck();
        }

        [Then(@"Pop up Certification should delete successfully")]
        public void ThenPopUpCertificationShouldDeleteSuccessfully()
        {
            PageCertificationObj.CertificationShouldDeleteSuccessfully();
        }

        [Then(@"Pop up Please Enter Certification Name Certification From And Certification Year")]
        public void ThenPopUpPleaseEnterCertificationNameCertificationFromAndCertificationYear()
        {
            PageCertificationObj.ErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear();
        }

    }
}
