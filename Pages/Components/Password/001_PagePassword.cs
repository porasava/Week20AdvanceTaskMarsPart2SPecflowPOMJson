using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.Password
{
    public class _001_PagePassword
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _001_PagePassword(IWebDriver driver)
        {
            driver1 = driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }
        private IWebElement AccountButton;
        private IWebElement changePasswordDropdown;
        private IWebElement CurrentPasswordText;
        private IWebElement NewPasswordText;
        private IWebElement ConfirmPasswordText;
        private IWebElement savePasswordButton;
        private IWebElement actualMessageText;

        public void renderPasswordAccountButtonComponents()
        {
            try
            {
                AccountButton = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderPasswordchangePasswordDropdownComponents()
        {
            try
            {
                changePasswordDropdown = driver1.FindElement(By.XPath("//a[normalize-space()='Change Password']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderPasswordchangePasswordComponents()
        {
            try
            {
                CurrentPasswordText = driver1.FindElement(By.XPath("//input[@placeholder='Current Password']"));
                NewPasswordText = driver1.FindElement(By.XPath("//input[@placeholder='New Password']"));
                ConfirmPasswordText = driver1.FindElement(By.XPath("//input[@placeholder='Confirm Password']"));
                savePasswordButton = driver1.FindElement(By.XPath("//button[@role='button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderPasswordactualMessageTextComponents()
        {
            try
            {
                actualMessageText = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //NavigateToPasswordPopUp
        public void NavigateToPasswordPopUp()
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"), 8);
            renderPasswordAccountButtonComponents();
            AccountButton.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//a[normalize-space()='Change Password']"), 8);
            renderPasswordchangePasswordDropdownComponents();
            changePasswordDropdown.Click();

        }


        //ChangePassword
        public void ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            Wait.WaitToBeClickable(driver1, By.XPath("//input[@placeholder='Current Password']"), 8);
            renderPasswordchangePasswordComponents();
            CurrentPasswordText.SendKeys(currentPassword);
            Wait.WaitToBeClickable(driver1, By.XPath("//input[@placeholder='New Password']"), 8);
            NewPasswordText.SendKeys(newPassword);
            Wait.WaitToBeClickable(driver1, By.XPath("//input[@placeholder='Confirm Password']"), 8);
            ConfirmPasswordText.SendKeys(confirmPassword);
            Wait.WaitToBeClickable(driver1, By.XPath("//button[@role='button']"), 8);
            savePasswordButton.Click();
        }

        //ShowPasswordChanged
        public void ShowPasswordChanged()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            renderPasswordactualMessageTextComponents();
            string actualMessage = actualMessageText.Text.Trim();
            string expectedMessage = "Password Changed Successfully"; // Replace with the actual expected text
            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
            Thread.Sleep(3000);
        }

        //PasswordVerificationFailed
        public void PasswordVerificationFailed()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            renderPasswordactualMessageTextComponents();
            string actualMessage = actualMessageText.Text.Trim();
            string expectedMessage = "Password Verification Failed"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //ErrorWhileUpdatingPasswordDetails
        public void ErrorWhileUpdatingPasswordDetails()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            renderPasswordactualMessageTextComponents();
            string actualMessage = actualMessageText.Text.Trim();
            string expectedMessage = "Error while Updating Password details"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }

        //PleaseFillAllTheDetailsBeforeSubmit
        public void PleaseFillAllTheDetailsBeforeSubmit()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            renderPasswordactualMessageTextComponents();
            string actualMessage = actualMessageText.Text.Trim();
            string expectedMessage = "Please fill all the details before Submit"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }


        //ErrorPasswordsRequiredAtLeastCharacters
        public void ErrorPasswordsRequiredAtLeastCharacters()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            renderPasswordactualMessageTextComponents();
            string actualMessage = actualMessageText.Text.Trim();
            string expectedMessage = "Passwords required at least 6 characters"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }


        //ErrorPasswordsDoesNotMatch
        public void ErrorPasswordsDoesNotMatch()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            renderPasswordactualMessageTextComponents();
            string actualMessage = actualMessageText.Text.Trim();
            string expectedMessage = "Passwords does not match"; // Replace with the actual expected text

            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");

        }
    }
}
