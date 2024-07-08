using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.ManageRequest
{
    public class _006_PageManageRequest
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _006_PageManageRequest(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }
        private IWebElement searchSkillButton;
        private IWebElement listing;
        private IWebElement requestSkillTradeButton;
        private IWebElement confirmRequestSkillTradeButton;
        private IWebElement manageRequestsElement;
        private IWebElement receivedRequestsDropdown;
        private IWebElement acceptButton;
        private IWebElement declineButton;
        private IWebElement completeButton;
        private IWebElement reviewButton;
        private IWebElement sellerRate;
        private IWebElement serviceRate;
        private IWebElement recommendRate;
        private IWebElement saveButton;
        private IWebElement rateCheck;
        private IWebElement sendRequestButton;
        private IWebElement activateCheck;
        private IWebElement actionText;
        private IWebElement reccomenceRate;
        private IWebElement saveButtonReview;
        private IWebElement logoutButton;


        public void renderManageRequestLogoutComponents()
        {
            try
            {
                logoutButton = driver1.FindElement(By.XPath("//button[@class='ui green basic button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestsearchskillButtonComponents()
        {
            try
            {
                searchSkillButton = driver1.FindElement(By.XPath("//div[@class='ui secondary menu']//input[@placeholder='Search skills']"));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestListingComponents()
        {
            try
            {
                listing = driver1.FindElement(By.XPath("//p[@class='row-padded']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestrequestSkillTradeButtonComponents()
        {
            try
            {
                requestSkillTradeButton = driver1.FindElement(By.XPath("//div[contains(@class,'button')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestreceivedRequestsDropdownComponents()
        {
            try
            {
                receivedRequestsDropdown = driver1.FindElement(By.XPath("//a[normalize-space()='Received Requests']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestacceptButtonComponents()
        {
            try
            {
                acceptButton = driver1.FindElement(By.XPath("//button[@class='ui primary basic button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestactivateCheckComponents()
        {
            try
            {
                activateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestdeclineButtonComponents()
        {
            try
            {
                declineButton = driver1.FindElement(By.XPath("//button[@class='ui negative basic button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestcompleteButtonComponents()
        {
            try
            {
                completeButton = driver1.FindElement(By.XPath("//button[@type='button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestactionTextComponents()
        {
            try
            {
                actionText = driver1.FindElement(By.XPath("//button[@type='button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestmanageRequestsElementComponents()
        {
            try
            {
               
                manageRequestsElement = driver1.FindElement(By.XPath("//div[contains(text(), 'Manage Requests')]"));
                sendRequestButton = driver1.FindElement(By.XPath("//a[normalize-space()='Sent Requests']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestreviewButtonComponents()
        {
            try
            {
                reviewButton = driver1.FindElement(By.XPath("//tbody/tr[1]/td[8]/button[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestreviewComponents()
        {
            try
            {
                sellerRate = driver1.FindElement(By.XPath("//div[@id='communicationRating']//i[5]"));
                serviceRate = driver1.FindElement(By.XPath("//div[@id='serviceRating']//i[5]"));
                recommendRate = driver1.FindElement(By.XPath("//div[@id='recommendRating']//i[5]"));
                saveButton = driver1.FindElement(By.XPath("//div[@class='ui teal button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestrateCheckComponents()
        {
            try
            {
                rateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public void renderManageRequestconfirmRequestSkillTradeButtonComponents()
        {
            try
            {
                confirmRequestSkillTradeButton = driver1.FindElement(By.XPath("/html/body/div[4]/div/div[3]/button[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageRequestComponents()
        {
            try
            {
                logoutButton = driver1.FindElement(By.XPath("//button[@class='ui green basic button']"));
                searchSkillButton = driver1.FindElement(By.XPath("//div[@class='ui secondary menu']//input[@placeholder='Search skills']"));
                listing = driver1.FindElement(By.XPath("//p[@class='row-padded']"));
                requestSkillTradeButton = driver1.FindElement(By.XPath("//div[contains(@class,'button')]"));
                confirmRequestSkillTradeButton = driver1.FindElement(By.XPath("/html/body/div[4]/div/div[3]/button[1]"));
                manageRequestsElement = driver1.FindElement(By.XPath("//div[contains(text(), 'Manage Requests')]"));
                receivedRequestsDropdown = driver1.FindElement(By.XPath("//a[normalize-space()='Received Requests']"));
                acceptButton = driver1.FindElement(By.XPath("//button[@class='ui primary basic button']"));
                declineButton = driver1.FindElement(By.XPath("//button[@class='ui negative basic button']"));
                completeButton = driver1.FindElement(By.XPath("//button[@type='button']"));
                reviewButton = driver1.FindElement(By.XPath("//tbody/tr[1]/td[8]/button[1]"));
                sellerRate = driver1.FindElement(By.XPath("//div[@id='communicationRating']//i[5]"));
                serviceRate = driver1.FindElement(By.XPath("//div[@id='serviceRating']//i[5]"));
                recommendRate = driver1.FindElement(By.XPath("//div[@id='recommendRating']//i[5]"));
                saveButton = driver1.FindElement(By.XPath("//div[@class='ui teal button']"));
                rateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                sendRequestButton = driver1.FindElement(By.XPath("//a[normalize-space()='Sent Requests']"));
                activateCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                actionText = driver1.FindElement(By.XPath("//button[@type='button']"));
                reccomenceRate = driver1.FindElement(By.XPath("//div[@id='recommendRating']//i[5]"));
                saveButtonReview = driver1.FindElement(By.XPath("//div[@class='ui teal button']"));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        //LogoutFromSkillWebsite
        public void LogoutFromSkillWebsite()
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//button[@class='ui green basic button']"), 20);
            renderManageRequestLogoutComponents();
            logoutButton.Click();
            Thread.Sleep(1000);
            // driver1.Quit();
        }
        //SearchforAskill
        public void SearchforAskill(string title)
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@class='ui secondary menu']//input[@placeholder='Search skills']"), 20);
            renderManageRequestsearchskillButtonComponents();
            searchSkillButton.SendKeys(title);
            searchSkillButton.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

        }

        //SearchForAListingAndSendRequest
        public void SearchForAListingAndSendRequest(string title)
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//p[@class='row-padded']"), 20);
            renderManageRequestListingComponents();
            listing.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//div[contains(@class,'button')]"), 20);
            renderManageRequestrequestSkillTradeButtonComponents();
            requestSkillTradeButton.Click();
            renderManageRequestconfirmRequestSkillTradeButtonComponents();
            confirmRequestSkillTradeButton.Click();
        }

        //ManageRequestDropdownAndSelectReceivedRequests
        public void ManageRequestDropdownAndSelectReceivedRequests()
        {
            Thread.Sleep(1000);
            Actions action = new Actions(driver1);
            renderManageRequestmanageRequestsElementComponents();
            action.MoveToElement(manageRequestsElement).Perform();
            Wait.WaitToBeClickable(driver1, By.XPath("//a[normalize-space()='Received Requests']"), 20);
            renderManageRequestreceivedRequestsDropdownComponents();
            receivedRequestsDropdown.Click();
            Thread.Sleep(1000);

        }

        //ClickAccept
        public void ClickAccept()
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//button[@class='ui primary basic button']"), 20);
            renderManageRequestacceptButtonComponents();
            acceptButton.Click();
            Thread.Sleep(1000);

        }


        public void TheListingStatusShouldChangeToCompleteOnReceiveRequest()
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//div[@class='ns-box-inner']"), 20);
            renderManageRequestactivateCheckComponents();
            string actualactivateCheck = activateCheck.Text.Trim();
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Service has been updated";
            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            By locator = By.XPath("//div[@class='ns-box-inner']");
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);
            Thread.Sleep(2000);
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@class='ns-box-inner']"), 20);
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);
        }

        //ListingStatusShouldChangeToDeclined
        public void ListingStatusShouldChangeToDeclined()
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//div[@class='ns-box-inner']"), 20);
            string expectedactivateCheckStaticPart = "Service has been updated";
            By locator = By.XPath("//div[@class='ns-box-inner']");
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);
            Thread.Sleep(1000);

        }


        //ManageRequestDropdownAndSelectSelectSendRequests
        public void ClickDecline()
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//button[@class='ui negative basic button']"), 20);
            renderManageRequestdeclineButtonComponents();
            declineButton.Click();
            Thread.Sleep(1000);

        }

        //ClickCompleted
        public void ClickCompleted()
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//button[@type='button']"), 20);
            renderManageRequestcompleteButtonComponents();
            completeButton.Click();
            Thread.Sleep(1000);

        }

        //TheListingStatusShouldChangeToCompleteOnReceiveRequest
        public void ChangeToCompleteOnReceiveRequest()
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//div[@class='ns-box-inner']"), 20);
            string expectedactivateCheckStaticPart = "Service has been updated";
            By locator = By.XPath("//div[@class='ns-box-inner']");
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//button[@type='button']"), 20);
            renderManageRequestactionTextComponents();
            string actionactualText = actionText.Text.Trim();
            // The static part of the message you expect
            Assert.That(actionactualText.Contains("Complete"), $"location of element does not match expected.");
        }



        //ManageRequestDropdownAndSelectSelectSendRequests
        public void ManageRequestDropdownAndSelectSelectSendRequests()
        {
            Thread.Sleep(1000);
            Actions action = new Actions(driver1);
            renderManageRequestmanageRequestsElementComponents();
            action.MoveToElement(manageRequestsElement).Perform();
            Wait.WaitToBeClickable(driver1, By.XPath("//a[normalize-space()='Sent Requests']"), 20);
            sendRequestButton.Click();
            Thread.Sleep(1000);

        }


        //ListingStatusShouldChangeToReview
        public void ListingStatusShouldChangeToReview()
        {
            Thread.Sleep(1000);
            Wait.WaitForElementPresent(driver1, By.XPath("//tbody/tr[1]/td[8]/button[1]"), 20);
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//button[@type='button']"), 20);
            renderManageRequestactionTextComponents();
            string actionactualText = actionText.Text.Trim();
            // The static part of the message you expect
            Assert.That(actionactualText.Contains("Review"), $"location of element does not match expected.");

        }

        //ClickReview
        public void ClickReview()
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//tbody/tr[1]/td[8]/button[1]"), 20);
            renderManageRequestreviewButtonComponents();
            reviewButton.Click();
            Thread.Sleep(2000);
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@id='communicationRating']//i[5]"), 20);
            renderManageRequestreviewComponents();
            sellerRate.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@id='serviceRating']//i[5]"), 20);
            serviceRate.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@id='recommendRating']//i[5]"), 20);
            reccomenceRate.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@class='ui teal button']"), 20);
            saveButtonReview.Click();
            Thread.Sleep(1000);

        }

        //ListingShouldShowReviewRateSuccessful
        public void ListingShouldShowReviewRateSuccessful()
        {

            Wait.WaitForElementPresent(driver1, By.XPath("//div[@class='ns-box-inner']"), 20);
            string expectedrateCheckStaticPart = "Rating added, thank you!";
            By locator = By.XPath("//div[@class='ns-box-inner']");
            pageAssertions.AssertElementTextContainsIWeb(expectedrateCheckStaticPart, locator);

            Thread.Sleep(1000);

        }


        [AfterScenario]
        public void AfterScenario(IWebDriver driver1)
        {
            driver1.Quit();
        }
    }
}
