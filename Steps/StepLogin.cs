using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.SIgnIn;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Steps
{
    public class StepLogin
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;

        public StepLogin(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
        }
        public void Login(string username, string password)
        {
            loginPageObj.NavigateToSkillsWeb();
            loginPageObj.InputUsernameAndPassword(username, password);
            loginPageObj.ClickOnLogin();

        }
    }
}
