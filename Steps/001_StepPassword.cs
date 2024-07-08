using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Models;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.Password;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.SIgnIn;
using Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Steps
{
    [Binding]
    public class _001_StepPassword
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _001_PagePassword pagePasswordObj;
        private List<ModelLogin> _ModelLogin;
        private List<_001_ModelPassword> _ModelPassword;
        private readonly _001_ModelPassword PasswordModel;

        public _001_StepPassword(IWebDriver _driver)
        {
            this.driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            pagePasswordObj = new _001_PagePassword(driver1);
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);

            string jsonFilePathPassword = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "001_TestDataPassword.json");
            _ModelPassword = JsonReader.ReadPasswordData(jsonFilePathPassword);

            PasswordModel = _ModelPassword.FirstOrDefault();
        }


        [When(@"I navigate to password pop up")]
        public void WhenINavigateToPasswordPopUp()
        {
            pagePasswordObj.NavigateToPasswordPopUp();
        }

        [When(@"I change password")]
        public void WhenIChangePassword()
        {
            pagePasswordObj.ChangePassword(PasswordModel.CurrentPassword, PasswordModel.NewPassword, PasswordModel.ConfirmPassword);
        }

        [Then(@"It should show pop up Password Changed Successfully")]
        public void ThenItShouldShowPopUpPasswordChangedSuccessfully()
        {
            pagePasswordObj.ShowPasswordChanged();
        }

        [Then(@"I change password back")]
        public void ThenIChangePasswordBack()
        {
            pagePasswordObj.NavigateToPasswordPopUp();
            pagePasswordObj.ChangePassword(PasswordModel.CurrentPassword2, PasswordModel.NewPassword2, PasswordModel.ConfirmPassword2);
        }


    }
}
