using AventStack.ExtentReports.Model;
using NUnit.Framework;
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
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Steps
{
    [Binding]
    public class _006_StepManageRequest 

    {
        private readonly IWebDriver driver1;
        private readonly StepLogin loginStepObj;
        private readonly _005_PageManageListing pageListingObj;
        private readonly _006_PageManageRequest pageManageRequestObj;
        private List<ModelLogin> _ModelLogin;
        private List<_006_ModelManageRequest> _ModelManageRequest;
        private readonly _006_ModelManageRequest ManageRequestModel;

        public _006_StepManageRequest(IWebDriver _driver)
        {
            this.driver1 = _driver;
            loginStepObj = new StepLogin(driver1);
            pageListingObj = new _005_PageManageListing(driver1);
            pageManageRequestObj = new _006_PageManageRequest(driver1);
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);

            string jsonFilePathManageRequest = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "006_TestDataManageRequest.json");
            _ModelManageRequest = JsonReader.ReadManageRequestData(jsonFilePathManageRequest);

            ManageRequestModel = _ModelManageRequest.FirstOrDefault();
        }

        //[SetUp]
        //public new void Initialize()
        //{

        //    string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
        //    _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);

        //    string jsonFilePathManageRequest = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "006_TestDataManageRequest.json");
        //    _ModelManageRequest = JsonReader.ReadManageRequestData(jsonFilePathManageRequest);
           
        //}

        [Given(@"I logout from Skill website")]
        public void GivenILogoutFromSkillWebsite()
        {
            pageManageRequestObj.LogoutFromSkillWebsite();
        }


        [When(@"I logout from Skill website")]
        public void WhenILogoutFromSkillWebsite()
        {
            pageManageRequestObj.LogoutFromSkillWebsite();
        }

        [When(@"I click on Manage request dropdown and select Received requests")]
        public void WhenIClickOnManageRequestDropdownAndSelectReceivedRequests()
        {
            pageManageRequestObj.ManageRequestDropdownAndSelectReceivedRequests();
        }

        [When(@"I click accept")]
        public void WhenIClickAccept()
        {
            pageManageRequestObj.ClickAccept();
        }

        [Then(@"the listing status should change to complete on receive request")]
        public void ThenTheListingStatusShouldChangeToCompleteOnReceiveRequest()
        {
            pageManageRequestObj.TheListingStatusShouldChangeToCompleteOnReceiveRequest();
        }

        [When(@"I click decline")]
        public void WhenIClickDecline()
        {
            pageManageRequestObj.ClickDecline();
        }

        [When(@"I click completed")]
        public void WhenIClickCompleted()
        {
            pageManageRequestObj.ClickCompleted();
        }

        [Then(@"the listing status should change to declined")]
        public void ThenTheListingStatusShouldChangeToDeclined()
        {
            pageManageRequestObj.ListingStatusShouldChangeToDeclined();
        }


        [Then(@"the listing status should change to review")]
        public void ThenTheListingStatusShouldChangeToReview()
        {
            pageManageRequestObj.ListingStatusShouldChangeToReview();

        }


        [When(@"I click review")]
        public void WhenIClickReview()
        {
            pageManageRequestObj.ClickReview();
        }

        [Then(@"this listing should show review rate successful")]
        public void ThenThisListingShouldShowReviewRateSuccessful()
        {
            pageManageRequestObj.ListingShouldShowReviewRateSuccessful();
        }

        [Given(@"I logged into Skill website successfully")]
        public void GivenILoggedIntoSkillWebsiteSuccessfully()
        {
            // Example for logging in with the first user in the JSON file for demonstration

            if (ManageRequestModel != null)
            {
                loginStepObj.Login(ManageRequestModel.UserName1, ManageRequestModel.Password);
            }
        }


        [Given(@"I create a listing")]
        public void GivenICreateAListing()
        {
            // Similar logic for creating a listing, assuming you have a page object for it
            
            if (ManageRequestModel != null)
            {
                pageListingObj.CreateAListing(ManageRequestModel.Title, ManageRequestModel.Description, ManageRequestModel.Category, ManageRequestModel.Subcategory, ManageRequestModel.Tags, ManageRequestModel.SkillExchange);
            }
        }

        [When(@"I search for a listing and send request")]
        public void WhenISearchForAListingAndSendRequest()
        {
            if (ManageRequestModel != null)
            {
                pageManageRequestObj.SearchforAskill(ManageRequestModel.Title);
                pageManageRequestObj.SearchForAListingAndSendRequest(ManageRequestModel.Title);
            }
        }

        [Given(@"I logged into Skill website with second user successfully")]
        public void GivenILoggedIntoSkillWebsiteWithSecondUserSuccessfully()
        {
            if (ManageRequestModel != null)
            {
                loginStepObj.Login(ManageRequestModel.UserName2, ManageRequestModel.Password);
            }
        }

        [When(@"I logged into Skill website with first user successfully")]
        public void WhenILoggedIntoSkillWebsiteWithFirstUserSuccessfully()
        {
            if (ManageRequestModel != null)
            {
                loginStepObj.Login(ManageRequestModel.UserName1, ManageRequestModel.Password);
            }
        }

        [When(@"I click on Manage request dropdown and select send requests")]
        public void WhenIClickOnManageRequestDropdownAndSelectSendRequests()
        {
            pageManageRequestObj.ManageRequestDropdownAndSelectSelectSendRequests();
        }


    }
}
