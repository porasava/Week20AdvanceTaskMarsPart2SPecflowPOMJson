using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.Profile
{
    public class _004_PageDescription

    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _004_PageDescription(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }
        private IWebElement editIcon;
        private IWebElement descriptionText;
        private IWebElement descriptionSave;
        private IWebElement description;
        private IWebElement originalDescriptionText;

        public void renderDescriptioneditIconComponents()
        {
            try
            {
                editIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderDescriptionTextComponents()
        {
            try
            {
                descriptionText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
                descriptionSave = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDescriptiondescriptionComponents()
        {
            try
            {
                description = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderDescriptionoriginalDescriptionTextComponents()
        {
            try
            {
               originalDescriptionText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        //EditDescription
        public void editDescription(string description)
        {
            Wait.WaitToExist(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"), 8);
            renderDescriptioneditIconComponents();
            editIcon.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"), 8);
            Thread.Sleep(1000);
            renderDescriptionTextComponents();
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"), 8);
            descriptionSave.Click();

        }


        //DescriptionShouldBeEditSuccessfully
        public void descriptionShouldBeEditSuccessfully()
        {
            Wait.WaitToExist(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"), 8);
            // Set the expected message for the language element
            string expectedMessage = "Hello Description TS_400_TC_001"; // Replace with the actual expected text
            //// Assert and print the expected and actual message
            By locator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span");
            pageAssertions.AssertElementTextContainsIWeb(expectedMessage, locator);

        }
        //EditBackToTheOriginalDescription
        public void EditBackToTheOriginalDescription(string originalDescription)
        {
            Wait.WaitToExist(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"), 8);
            renderDescriptioneditIconComponents();
            editIcon.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"), 8);
            Thread.Sleep(1000);
            renderDescriptionTextComponents();
            descriptionText.Clear();
            descriptionText.SendKeys(originalDescription);
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"), 8);
            descriptionSave.Click();
            Wait.WaitToExist(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"), 8);
            string expectedMessage = "Hi"; // Replace with the actual expected text
            //// Assert and print the expected and actual message
            By locator = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span");
            pageAssertions.AssertElementTextContainsIWeb(expectedMessage, locator);

        }

    }
}
