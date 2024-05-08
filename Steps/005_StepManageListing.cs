using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.ManageListing;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.ManageRequest;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.SIgnIn;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Steps
{
    [Binding]
    public class _005_StepManageListing
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _005_PageManageListing PageManageListingObj;
        private List<_005_ModelManageListing> _ModelManageListing;
        private readonly _005_ModelManageListing ManageListingModel;
        private readonly ModelLogin LoginModel;
        private List<ModelLogin> _ModelLogin;
        private readonly _006_PageManageRequest pageManageRequestObj;


        public _005_StepManageListing(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            PageManageListingObj = new _005_PageManageListing(driver1);
            pageManageRequestObj = new _006_PageManageRequest(driver1);
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);

            string jsonFilePathManageListing = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "005_TestDataManageListing.json");
            _ModelManageListing = JsonReader.ReadManageListingData(jsonFilePathManageListing);
            LoginModel = _ModelLogin.FirstOrDefault();
        }

        private _005_ModelManageListing GetCurrentTestData()
        {
            var currentTestCaseId = ScenarioContext.Current.ScenarioInfo.Tags.FirstOrDefault();
            var currentTestData = _ModelManageListing.FirstOrDefault(cer => cer.TestCaseId == currentTestCaseId);

            if (currentTestData == null)
                throw new InvalidOperationException($"No test data found for TestCaseId: {currentTestCaseId}");

            return currentTestData;
        }



        [When(@"I navigate to Manage listing page")]
        public void WhenINavigateToManageListingPage()
        {
            PageManageListingObj.NavigateToManageListingPage();
        }
        [Given(@"I created a listing")]
        public void GivenICreatedAListing()
        {
            var currentTestData = GetCurrentTestData();
            PageManageListingObj.CreateAListing(currentTestData.Title, currentTestData.Description, currentTestData.Category, currentTestData.SubCategory, currentTestData.Tags, currentTestData.SkillExchange);

        }


        [When(@"I edit listing")]
        public void WhenIEditListing()
        {
            var currentTestData = GetCurrentTestData();
            PageManageListingObj.EditAListing(currentTestData.TitleEdit, currentTestData.DescriptionEdit, currentTestData.CategoryEdit, currentTestData.SubCategoryEdit, currentTestData.TagsEdit, currentTestData.SkillExchangeEdit);
        }

        [Then(@"It should show the listing update on the listing detail page")]
        public void ThenItShouldShowTheListingUpdateOnTheListingDetailPage()
        {
            var currentTestData = GetCurrentTestData();
            PageManageListingObj.ListingUpdateOnTheListingDetailPage(currentTestData.TitleEdit, currentTestData.DescriptionEdit);    
        }

        [When(@"I click on see listing")]
        public void WhenIClickOnSeeListing()
        {
            var currentTestData = GetCurrentTestData();
            PageManageListingObj.ClickOnSeeListing(currentTestData.Title);


        }

        [Then(@"It should show the listing on the listing detail page")]
        public void ThenItShouldShowTheListingOnTheListingDetailPage()
        {
            var currentTestData = GetCurrentTestData();
            PageManageListingObj.ShowTheListingOnTheListingDetailPage(currentTestData.Title, currentTestData.Description, currentTestData.Category, currentTestData.SubCategory, currentTestData.SkillExchange, currentTestData.LocationType);
        }

        [When(@"I click on delete listing")]
        public void WhenIClickOnDeleteListing()
        {
            var currentTestData = GetCurrentTestData();
            PageManageListingObj.DeleteListing(currentTestData.Title);
        }

        [Then(@"The listing should be delete successfully")]
        public void ThenTheListingShouldBeDeleteSuccessfully()
        {
            PageManageListingObj.ListingShouldBeDeleteSuccessfully();
        }

        [When(@"I click on activate listing")]
        public void WhenIClickOnActivateListing()
        {
            PageManageListingObj.ClickOnActivateListing();
        }

        [Then(@"It should show Service has been activated")]
        public void ThenItShouldShowServiceHasBeenActivated()
        {
            PageManageListingObj.ServiceHasBeenActivated();
        }

        [When(@"I click on Deactivate listing")]
        public void WhenIClickOnDeactivateListing()
        {
            PageManageListingObj.ClickOnDeactivateListing();
        }

        [Then(@"It should show Service has been deactivated")]
        public void ThenItShouldShowServiceHasBeenDeactivated()
        {
            PageManageListingObj.ShowServiceHasBeenDeactivated();
        }
        [When(@"I click on Manage request dropdown and select send Requests")]
        public void WhenIClickOnManageRequestDropdownAndSelectSendRequests()
        {
            pageManageRequestObj.ManageRequestDropdownAndSelectSelectSendRequests();
        }


    }
}
