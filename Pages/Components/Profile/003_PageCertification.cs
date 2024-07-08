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
    public class _003_PageCertification
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _003_PageCertification(IWebDriver driver)
        {
            driver1 = driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }
        private IWebElement certificationTab;
        private IWebElement PopUp;
        private IWebElement addNewcertification;
        private IWebElement certificationText;
        private IWebElement fromText;
        private IWebElement yearDropdown;
        private IWebElement addCertification;
        private IWebElement editcertification;
        private IWebElement editCertificationUpdate;
        private IWebElement removeIcon;
        private IWebElement cancel;

        public void renderCertificationTabComponents()
        {
            try
            {
                certificationTab = driver1.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderCertificationaddNewComponents()
        {
            try
            {
                addNewcertification = driver1.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderCertificationaddNewFieldsComponents()
        {
            try
            {
                certificationText = driver1.FindElement(By.XPath("//input[@name='certificationName']"));
                fromText = driver1.FindElement(By.XPath("//input[@name='certificationFrom']"));
                yearDropdown = driver1.FindElement(By.XPath("//select[@name='certificationYear']"));
                addCertification = driver1.FindElement(By.XPath("//input[@value='Add']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderCertificationRemoveIconComponents()
        {
            try
            {
                removeIcon = driver1.FindElement(By.XPath("//i[@class='remove icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderCertificationCancelComponents()
        {
            try
            {
                cancel = driver1.FindElement(By.XPath("//input[@value='Cancel']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderCertificationEditComponents()
        {
            try
            {
                editcertification = driver1.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderCertificationEditFieldsComponents()
        {
            try
            {
                certificationText = driver1.FindElement(By.XPath("//input[@name='certificationName']"));
                fromText = driver1.FindElement(By.XPath("//input[@name='certificationFrom']"));
                yearDropdown = driver1.FindElement(By.XPath("//select[@name='certificationYear']"));
                editCertificationUpdate = driver1.FindElement(By.XPath("//input[@value='Update']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //AddANewCertification
        public void AddANewCertification(string certificateOrAward, string from, string year)
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//a[normalize-space()='Certifications']"), 8);
            renderCertificationTabComponents();
            certificationTab.Click();
            // Thread.Sleep(1000);
            Wait.WaitForElementPresent(driver1, By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"), 8);
            renderCertificationaddNewComponents();
            addNewcertification.Click();
            renderCertificationaddNewFieldsComponents();
            certificationText.Clear();
            certificationText.SendKeys(certificateOrAward);
            fromText.Clear();
            fromText.SendKeys(from);
            yearDropdown.Click();
            yearDropdown.SendKeys(year);
            addCertification.Click();
        }

        //CertificationShouldBeAddSuccessfully
        public void CertificationShouldBeAddSuccessfully()
        {
            Thread.Sleep(500);
            Wait.WaitForElementPresent(driver1, By.XPath("/html/body/div[1]/div"), 8);
            // The static part of the message you expect
            string expectedStaticPart = "has been added to your certification";
            // Assert that the actual message contains the expected static part
            By locator = By.XPath("/html/body/div[1]/div");
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //DeleteCertification
        public void DeleteCertification(string certificationDelete)
        {
            Thread.Sleep(500);
            string certificationToRemove = certificationDelete;
            // Find the table row that contains the specified 
            IWebElement rowContainingCertification = driver1.FindElement(By.XPath($"//td[normalize-space()='{certificationToRemove}']"));
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingCertification.FindElement(By.XPath("//i[@class='remove icon']"));
            // Click the "Remove" icon
            renderCertificationRemoveIconComponents();
            removeIcon.Click();

        }

        //DeleteAEducation
        public void DeleteACertificationNoCheck()
        {
            Thread.Sleep(500);
            renderCertificationRemoveIconComponents();
            removeIcon.Click();

        }

        //CancelUpdate
        public void CancelACertification()
        {
            Thread.Sleep(500);
            renderCertificationCancelComponents();
            cancel.Click();

        }

        //CertificationShouldDeleteSuccessfully
        public void CertificationShouldDeleteSuccessfully()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            // The static part of the message you expect
            string expectedStaticPart = "has been deleted from your certification";
            // Assert that the actual message contains the expected static part
            By locator = By.XPath("/html/body/div[1]/div");
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }


        //ErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear
        public void ErrorPleaseEnterCertificationNameCertificationFromAndCertificationYear()
        {
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            // The static part of the message you expect
            string expectedStaticPart = "Please enter Certification Name, Certification From and Certification Year";
            By locator = By.XPath("/html/body/div[1]/div");
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //EditACertification
        public void EditACertification(string certificateOrAwardEdit, string fromEdit, string yearEdit)
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//a[normalize-space()='Certifications']"), 8);
            renderCertificationTabComponents();
            certificationTab.Click();
            Thread.Sleep(500);
            renderCertificationEditComponents();
            editcertification.Click();
            renderCertificationEditFieldsComponents();
            certificationText.Clear();
            certificationText.SendKeys(certificateOrAwardEdit);
            fromText.Clear();
            fromText.SendKeys(fromEdit);
            yearDropdown.Click();
            yearDropdown.SendKeys(yearEdit);
            editCertificationUpdate.Click();
        }

        //CertificationShouldBeEdit
        public void CertificationShouldBeEdit()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            // The static part of the message you expect
            string expectedStaticPart = "has been updated to your certification";
            By locator = By.XPath("/html/body/div[1]/div");
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //This information is already exist.
        public void ThisInformationIsAlreadyExist()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            // The static part of the message you expect
            string expectedStaticPart = "This information is already exist";
            By locator = By.XPath("/html/body/div[1]/div");
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }


        public bool IsDataPresent()
        {
            // Implement logic to check if data is present
            // For example, checking if a specific element or row exists
            try
            {
                Thread.Sleep(1000);
                driver1.FindElement(By.XPath("//i[@class='remove icon']"));
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public void DeleteData()
        {
            // Implement the logic to delete the data
            // For example, clicking a delete button
            renderCertificationRemoveIconComponents();
            removeIcon.Click();
            // Add any additional waits or logic needed after deletion
        }

        //CheckExistingdata
        public void CheckExistingCertification()
        {
            Thread.Sleep(1000);
            // Loop until no more data is present
            while (IsDataPresent())
            {
                DeleteData();
            }
        }

        //GoToCertificationTab
        public void GoToCertificationTab()
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//a[normalize-space()='Certifications']"), 8);
            renderCertificationTabComponents();
            certificationTab.Click();
            Thread.Sleep(500);
        }
    }
}
