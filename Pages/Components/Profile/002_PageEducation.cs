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
    public class _002_PageEducation
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;


        public _002_PageEducation(IWebDriver driver)
        {
            driver1 = driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }
        private IWebElement educationTab;
        private IWebElement addNewEducation;
        private IWebElement PopUp;
        private IWebElement university;
        private IWebElement countryDropdown;
        private IWebElement titleDropdown;
        private IWebElement degreeText;
        private IWebElement yearDropdown;
        private IWebElement addEducation;
        private IWebElement editEducation;
        private IWebElement educationUpdate;
        private IWebElement educationCancel;
        private IWebElement removeIcon;
        private IWebElement cancel;

        public void renderEducationTabComponents()
        {
            try
            {
                educationTab = driver1.FindElement(By.XPath("//a[normalize-space()='Education']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderEducationAddComponents()
        {
            try
            {
                addNewEducation = driver1.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    
        public void renderEducationAddFieldsComponents()
        {
            try
            {
                university = driver1.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                countryDropdown = driver1.FindElement(By.XPath("//select[@name='country']"));
                titleDropdown = driver1.FindElement(By.XPath("//select[@name='title']"));
                degreeText = driver1.FindElement(By.XPath("//input[@name='degree']"));
                yearDropdown = driver1.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                addEducation = driver1.FindElement(By.XPath("//div[@class='sixteen wide field']//input[@value='Add']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderEducationPopupComponents()
        {
            try
            {
                PopUp = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderEducationremoveIconComponents()
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
        public void renderEducationcancelComponents()
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
        public void renderEducationuniversityComponents()
        {
            try
            {
                university = driver1.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderEducationEditComponents()
        {
            try
            {
                editEducation = driver1.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderEducationUpdateComponents()
        {
            try
            {
                educationUpdate = driver1.FindElement(By.XPath("//input[@value = 'Update']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderEducationEditFieldsComponents()
        {
            try
            {
                university = driver1.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                countryDropdown = driver1.FindElement(By.XPath("//select[@name='country']"));
                titleDropdown = driver1.FindElement(By.XPath("//select[@name='title']"));
                degreeText = driver1.FindElement(By.XPath("//input[@name='degree']"));
                yearDropdown = driver1.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

         //AddANewEducation
        public void AddANewEducation(string universityName, string country, string title, string degree, string yearOfGraduate)
        {

            Wait.WaitForElementPresent(driver1, By.XPath("//a[normalize-space()='Education']"), 8);
            renderEducationTabComponents();
            educationTab.Click();
            Thread.Sleep(1000);
            Wait.WaitForElementPresent(driver1, By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"), 8);
            renderEducationAddComponents();
            addNewEducation.Click();
            renderEducationAddFieldsComponents();
            university.Clear();
            university.SendKeys(universityName);
            countryDropdown.Click();
            countryDropdown.SendKeys(country);
            titleDropdown.Click();
            titleDropdown.SendKeys(title);
            degreeText.Clear();
            degreeText.SendKeys(degree);
            yearDropdown.Click();
            yearDropdown.SendKeys(yearOfGraduate);
            addEducation.Click();
        }

        //EducationShouldBeAddSuccessfully
        public void EducationShouldBeAddSuccessfully()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            string expectedStaticPart = "Education has been added";
            By locator = By.XPath("/html/body/div[1]/div");
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }


        //DeleteAEducation
        public void DeleteAEducation(string universityNameDelete)
        {
            Thread.Sleep(500);
            string educationToRemove = universityNameDelete; // Replace with the language name based on user input

            // Find the table row that contains the specified 
            IWebElement rowContainingEducation = driver1.FindElement(By.XPath($"//table/tbody/tr[td[contains(text(), '{educationToRemove}')]]"));
            Thread.Sleep(500);
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingEducation.FindElement(By.XPath("//i[@class='remove icon']"));

            // Click the "Remove" icon
            renderEducationremoveIconComponents();
            removeIcon.Click();

        }

        //DeleteAEducation
        public void DeleteAnEducationNoCheck()
        {
            Thread.Sleep(500);
            renderEducationremoveIconComponents();
            removeIcon.Click();

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
            renderEducationremoveIconComponents();
            removeIcon.Click();
        }

        //CheckExistingdata
        public void CheckExistingEducation()
        {
            Thread.Sleep(1000);
            // Loop until no more data is present
            while (IsDataPresent())
            {
                DeleteData();
            }
        }

        //CancelAEducation
        public void CancelAEducation()
        {
            renderEducationcancelComponents();
            cancel.Click();

        }

        //ClearAEducationUniversity
        public void ClearAEducationUniversity()
        {
            renderEducationuniversityComponents();
            university.Clear();

        }

        //EducationShouldDeleteSuccessfully
        public void EducationShouldDeleteSuccessfully()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            string expectedStaticPart = "Education entry successfully removed";
            By locator = By.XPath("/html/body/div[1]/div");
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //EducationErrorPleaseEnterAllTheFields
        public void EducationErrorPleaseEnterAllTheFields()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            string expectedStaticPart = "Please enter all the fields";
            By locator = By.XPath("/html/body/div[1]/div");
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //EducationErrorThisInformationIsAlreadyExist.
        public void EducationErrorThisInformationIsAlreadyExist()
        {
            Thread.Sleep(500);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            string expectedStaticPart = "This information is already exist";
            By locator = By.XPath("/html/body/div[1]/div");
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);

        }

        //EditEducation
        public void EditEducation(string universityNameEdit, string countryEdit, string titleEdit, string degreeEdit, string yearOfGraduateEdit)
        {
            Wait.ElementIsVisible(driver1, By.XPath("//a[normalize-space()='Education']"), 8);
            renderEducationTabComponents();
            educationTab.Click();
            Thread.Sleep(500);
            renderEducationEditComponents();
            editEducation.Click();
            AddANewEducation(universityNameEdit, countryEdit, titleEdit, degreeEdit, yearOfGraduateEdit);
            renderEducationUpdateComponents();
            educationUpdate.Click();
        }

        //EditEducationDown
        public void EditEducationDown(string universityNameEdit, string countryEdit, string titleEdit, string degreeEdit, string yearOfGraduateEdit)
        {
            Wait.ElementIsVisible(driver1, By.XPath("//a[normalize-space()='Education']"), 8);
            renderEducationTabComponents();
            educationTab.Click();
            Thread.Sleep(500);
            renderEducationEditComponents();
            editEducation.Click();
            renderEducationEditFieldsComponents();
            university.Clear();
            university.SendKeys(universityNameEdit);
            countryDropdown.Click();
            countryDropdown.SendKeys(countryEdit);
            titleDropdown.Click();
            titleDropdown.SendKeys(titleEdit);
            degreeText.Clear();
            degreeText.SendKeys(degreeEdit);
            yearDropdown.Click();
            yearDropdown.SendKeys(yearOfGraduateEdit);
            renderEducationUpdateComponents();
            educationUpdate.Click();
        }

        //AddANewEducationCancel
        public void AddANewEducationCancel(string universityName, string country, string title, string degree, string yearOfGraduate)
        {

            Wait.WaitForElementPresent(driver1, By.XPath("//a[normalize-space()='Education']"), 8);
            renderEducationTabComponents();
            educationTab.Click();
            Thread.Sleep(500);
            Wait.WaitForElementPresent(driver1, By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"), 8);
            renderEducationAddComponents();
            addNewEducation.Click();
            university.Clear();
            university.SendKeys(universityName);
            countryDropdown.Click();
            countryDropdown.SendKeys(country);
            titleDropdown.Click();
            titleDropdown.SendKeys(title);
            degreeText.Clear();
            degreeText.SendKeys(degree);
            yearDropdown.Click();
            yearDropdown.SendKeys(yearOfGraduate);
            renderEducationcancelComponents();
            cancel.Click();
        }

        //GoToEducationPage
        public void GotoEducationTab()
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//a[normalize-space()='Education']"), 8);
            renderEducationTabComponents();
            educationTab.Click();
        }
    }
}
