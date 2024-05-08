using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.SIgnIn
{
    public class PageLogin
    {
        private readonly IWebDriver driver1;

        public PageLogin(IWebDriver driver)
        {
            driver1 = driver;
        }
        private IWebElement usernameTextbox;
        private IWebElement passwordTextbox;
        private IWebElement loginButtonPopUp;
        private IWebElement AccountProfilePage;
        private IWebElement loginButton;
        private By loginButton1;

        public void renderInputUsernameAndPasswordComponents()
        {
            try
            {
                usernameTextbox = driver1.FindElement(By.XPath("//input[@placeholder='Email address']"));
                passwordTextbox = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderLoginComponents()
        {
            try
            {
                loginButton1 = By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a");
                loginButton = driver1.FindElement(loginButton1);
                loginButtonPopUp = driver1.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderGoToAccountProfilePageComponents()
        {
            try
            {
                AccountProfilePage = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/a"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void NavigateToSkillsWeb()
        {
            driver1.Manage().Window.Maximize();
            //Lunch TurnUp Portal and navigate to the website login page
            driver1.Navigate().GoToUrl("http://localhost:5001/Home");
        }

        public void InputUsernameAndPassword(string username, string password)
        {   
            renderLoginComponents();
            Wait.WaitForElementPresent(driver1, loginButton1, 8);
            // click SIgnIn button
            loginButton.Click();
            renderInputUsernameAndPasswordComponents();
            usernameTextbox.SendKeys(username);
            passwordTextbox.SendKeys(password);
        }

        public void ClickOnLogin()
        {
            renderLoginComponents();
            loginButtonPopUp.Click();
        }

        public void GoToAccountProfilePage()
        {
            renderGoToAccountProfilePageComponents();
            Assert.That(AccountProfilePage.Text == "Mars Logo", "text is not show. It should show 'Mars Logo'");
        }

    }
}
