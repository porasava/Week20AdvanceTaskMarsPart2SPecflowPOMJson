using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.Profile;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.SIgnIn;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Steps
{
    [Binding]
    public class _002_StepEducation
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly StepLogin loginStepObj;
        private readonly _002_PageEducation PageEducationObj;
        private List<ModelLogin> _ModelLogin;
        private List<_002_ModelEducation> _ModelEducation;
        private readonly _002_ModelEducation EducationModel;
        private readonly ModelLogin LoginModel;

        public _002_StepEducation(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            loginStepObj = new StepLogin(driver1);
            PageEducationObj = new _002_PageEducation(driver1);
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);

            string jsonFilePathEducation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "002_TestDataEducation.json");
            _ModelEducation = JsonReader.ReadEducationData(jsonFilePathEducation);
            LoginModel = _ModelLogin.FirstOrDefault();
        }

        private _002_ModelEducation GetCurrentTestData()
        {
            var currentTestCaseId = ScenarioContext.Current.ScenarioInfo.Tags.FirstOrDefault();
            var currentTestData = _ModelEducation.FirstOrDefault(edu => edu.TestCaseId == currentTestCaseId);

            if (currentTestData == null)
                throw new InvalidOperationException($"No test data found for TestCaseId: {currentTestCaseId}");

            return currentTestData;
        }

        [Given(@"I checked existing Education")]
        public void GivenICheckedExistingEducation()
        {
            PageEducationObj.GotoEducationTab();
            PageEducationObj.CheckExistingEducation();
        }

        [When(@"I attempt to add a new Education with College Field left blank")]
        public void WhenIAttemptToAddANewEducationWithCollegeFieldLeftBlank()

        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        
    }

        [Then(@"an error message should be displayed: Please enter all fields")]
        public void ThenAnErrorMessageShouldBeDisplayedPleaseEnterAllFields()
        {
            PageEducationObj.EducationErrorPleaseEnterAllTheFields();
        }

        [Given(@"I have logged into the Skill website successfully")]
        public void GivenIHaveLoggedIntoTheSkillWebsiteSuccessfully()
        {
            // Example for logging in with the first user in the JSON file for demonstration
            if (EducationModel != null)
            {
                loginStepObj.Login(LoginModel.username, LoginModel.password);
            }
        }

        [Given(@"I have checked existing Education entries")]
        public void GivenIHaveCheckedExistingEducationEntries()
        {
            PageEducationObj.GotoEducationTab();
            PageEducationObj.CheckExistingEducation();
        }

        [When(@"I attempt to add a new Education with the Country field left blank")]
        public void WhenIAttemptToAddANewEducationWithTheCountryFieldLeftBlank()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }

        [When(@"I attempt to add a new Education with the Title field left blank")]
        public void WhenIAttemptToAddANewEducationWithTheTitleFieldLeftBlank()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }

        [When(@"I attempt to add a new Education with the Degree field left blank")]
        public void WhenIAttemptToAddANewEducationWithTheDegreeFieldLeftBlank()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }

        [When(@"I attempt to add a new Education with the Year of Graduation field left blank")]
        public void WhenIAttemptToAddANewEducationWithTheYearOfGraduationFieldLeftBlank()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }

        [When(@"I add a new Education entry")]
        public void WhenIAddANewEducationEntry()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }

        [Then(@"I click cancel")]
        public void ThenIClickCancel()
        {
            PageEducationObj.CancelAEducation();
        }

        [When(@"I add a new Education with special characters in the College field")]
        public void WhenIAddANewEducationWithSpecialCharactersInTheCollegeField()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }

        [Then(@"the Education entry should be added successfully")]
        public void ThenTheEducationEntryShouldBeAddedSuccessfully()
        {
            PageEducationObj.EducationShouldBeAddSuccessfully();
        }

        [Then(@"I delete an Education entry")]
        public void ThenIDeleteAnEducationEntry()
        {
            PageEducationObj.DeleteAnEducationNoCheck();
        }

        [Then(@"the Education entry should be deleted successfully")]
        public void ThenTheEducationEntryShouldBeDeletedSuccessfully()
        {
            PageEducationObj.EducationShouldDeleteSuccessfully();
        }
        [When(@"I add a new Education with more than letters in the College field")]
        public void WhenIAddANewEducationWithMoreThanLettersInTheCollegeField()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }

        [When(@"I add a new Education with more than letters in the Degree field")]
        public void WhenIAddANewEducationWithMoreThanLettersInTheDegreeField()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }



        [When(@"I attempt to add a duplicate Education entry")]
        public void WhenIAttemptToAddADuplicateEducationEntry()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }

        [Then(@"an error message should be displayed: This information already exists")]
        public void ThenAnErrorMessageShouldBeDisplayedThisInformationAlreadyExists()
        {
            PageEducationObj.EducationErrorThisInformationIsAlreadyExist();
        }

        [When(@"I added a new Education")]
        public void WhenIAddedANewEducation()
        {
            var currentTestData = GetCurrentTestData();

            // Use currentTestData instead of EducationModel
            PageEducationObj.AddANewEducation(currentTestData.UniversityName, currentTestData.Country, currentTestData.Title, currentTestData.Degree, currentTestData.YearOfGraduate);
        }

        [Then(@"Education should be add successfully")]
        public void ThenEducationShouldBeAddSuccessfully()
        {
            PageEducationObj.EducationShouldBeAddSuccessfully();
        }

        [Then(@"I deleted an Education")]
        public void ThenIDeletedAnEducation()
        {
            PageEducationObj.DeleteAnEducationNoCheck();
        }

        [Then(@"Education should be delete successfully")]
        public void ThenEducationShouldBeDeleteSuccessfully()
        {
            PageEducationObj.EducationShouldDeleteSuccessfully();
        }


    }
}
