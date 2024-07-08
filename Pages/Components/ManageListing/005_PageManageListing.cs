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

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Pages.Components.ManageListing
{
    public class _005_PageManageListing
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _005_PageManageListing(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }

        private IWebElement shareSkillButton;
        private IWebElement shareSkillTitle;
        private IWebElement descriptionText;
        private IWebElement DiscriptionTextDetailPage;
        private IWebElement categoryDropdown;
        private IWebElement tagsText;
        private IWebElement skillExchangeText;
        private IWebElement skillExchangeTextDetailPage;
        private IWebElement shareSkillSaveButton;
        private IWebElement manageListingButton;
        private IWebElement seeButton;
        private IWebElement EditSkillButton;
        private IWebElement subCategoryDropdown;
        private IWebElement skillTitle;
        private IWebElement categoryText;
        private IWebElement subCategoryText;
        private IWebElement locationText;
        private IWebElement activateButton;
        private IWebElement DeactivateButton;
        private IWebElement activateCheck;
        private IWebElement deleteCheck;
        private IWebElement PopupdeleteCheck;
        private IWebElement deleteButton;
        private IWebElement yesButton;
        private IWebElement ViewSkillTitle;

        public void renderManageListingshareSkillButtonComponents()
        {
            try
            {
                shareSkillButton = driver1.FindElement(By.XPath("//a[normalize-space()='Share Skill']"));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderManageListingShareSkillComponents()
        {
            try
            {
                
                shareSkillTitle = driver1.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
                descriptionText = driver1.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
                categoryDropdown = driver1.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        

        public void renderShareSkillTagComponents()
        {
            try
            {
                tagsText = driver1.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public void renderShareSkillSubCatComponents()
        {
            try
            {
                subCategoryDropdown = driver1.FindElement(By.XPath("//select[@name='subcategoryId']"));
                tagsText = driver1.FindElement(By.XPath("(//input[contains(@placeholder,'Add new tag')])[1]"));
                skillExchangeText = driver1.FindElement(By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]"));
                shareSkillTitle = driver1.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
                shareSkillSaveButton = driver1.FindElement(By.XPath("//input[@value='Save']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillExchangeComponents()
        {
            try
            {

                skillExchangeText = driver1.FindElement(By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]"));
               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public void renderShareSkillSaveButtonComponents()
        {
            try
            {
                shareSkillSaveButton = driver1.FindElement(By.XPath("//input[@value='Save']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillEditButtonComponents()
        {
            try
            {

                EditSkillButton = driver1.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[2]/i[1]"));
                skillTitle = driver1.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]"));
                descriptionText = driver1.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
                categoryText = driver1.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]"));
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillEditComponents()
        {
            try
            {

                shareSkillTitle = driver1.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
                descriptionText = driver1.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
                categoryDropdown = driver1.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")); 

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public void renderShareSkillcategoryDropdownComponents()
        {
            try
            {
                categoryDropdown = driver1.FindElement(By.XPath("//select[@name='categoryId']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillmanageListingButtonComponents()
        {
            try
            {
                manageListingButton = driver1.FindElement(By.XPath("//a[normalize-space()='Manage Listings']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillSeeComponents()
        {
            try
            {
                seeButton = driver1.FindElement(By.XPath("//i[@class='eye icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillSkillTitleComponents()
        {
            try
            {
                ViewSkillTitle = driver1.FindElement(By.XPath("//span[@class='skill-title']"));
                DiscriptionTextDetailPage = driver1.FindElement(By.XPath("//div[@class='sixteen wide column']//div[1]//div[1]//div[1]//div[2]"));
                categoryText = driver1.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]"));
                subCategoryText = driver1.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]"));
                skillExchangeTextDetailPage = driver1.FindElement(By.XPath("//span[@class='ui tag label']"));
                locationText = driver1.FindElement(By.XPath("//div[@class='ui container']//div[3]//div[1]//div[3]//div[1]//div[2]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillDeactivateButtonComponents()
        {
            try
            {
                DeactivateButton = driver1.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillActivateButtonComponents()
        {
            try
            {
                activateButton = driver1.FindElement(By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillactivateCheckComponents()
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
        public void renderShareSkilldeleteCheckComponents()
        {
            try
            {
                deleteCheck = driver1.FindElement(By.XPath("//tbody/tr[1]/td[3]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillPopupdeleteCheckComponents()
        {
            try
            {
                PopupdeleteCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillPopupdeleteButtonComponents()
        {
            try
            {
                deleteButton = driver1.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[3]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public void renderShareSkillYesButtonComponents()
        {
            try
            {
                yesButton = driver1.FindElement(By.XPath("//button[@class='ui icon positive right labeled button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }






        //CreateAListing
        public void CreateAListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            Wait.WaitToBeClickable(driver1, By.XPath("//a[normalize-space()='Share Skill']"), 20);
            renderManageListingshareSkillButtonComponents();
            shareSkillButton.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"), 20);
            renderManageListingShareSkillComponents();
            shareSkillTitle.SendKeys(title);
            Wait.WaitToBeClickable(driver1, By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"), 5);
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            Wait.WaitToBeClickable(driver1, By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"), 20);
            renderShareSkillcategoryDropdownComponents();
            categoryDropdown.SendKeys(category);
            Thread.Sleep(2000);
            if (string.IsNullOrEmpty(subCategory))
            {
                Wait.WaitToBeClickable(driver1, By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]"), 20);
                renderShareSkillTagComponents();
                tagsText.SendKeys(tags);
                tagsText.SendKeys(Keys.Enter);
            }
            else
            {
                Wait.WaitToBeClickable(driver1, By.XPath("//select[@name='categoryId']"), 5);
                renderShareSkillSubCatComponents();
                subCategoryDropdown.SendKeys(subCategory);
                tagsText.SendKeys(tags);
                tagsText.SendKeys(Keys.Enter);
            }
           // Wait.WaitToBeClickable(driver1, By.XPath("//span[@class='ui tag label']"), 5);
            renderShareSkillExchangeComponents();
            skillExchangeText.Click();
            skillExchangeText.SendKeys(skillExchange);
            skillExchangeText.SendKeys(Keys.Enter);
            //Wait.WaitToBeClickable(driver1, By.XPath("//a[normalize-space()='Manage Listings']"), 20);
            renderShareSkillSaveButtonComponents();
            shareSkillSaveButton.Click();
            Thread.Sleep(1000);
        }

        public void EditAListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {

            Wait.WaitToBeClickable(driver1, By.XPath("//tbody/tr[1]/td[8]/div[1]/button[2]/i[1]"), 20);
            renderShareSkillEditButtonComponents();
            EditSkillButton.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"), 20);
            renderShareSkillEditComponents();
            shareSkillTitle.Clear();
            shareSkillTitle.SendKeys(title);
            Wait.WaitToBeClickable(driver1, By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"), 20);
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            Wait.WaitToBeClickable(driver1, By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"), 20);
            categoryDropdown.SendKeys(category);
            Wait.WaitToBeClickable(driver1, By.XPath("//select[@name='subcategoryId']"), 20);
            renderShareSkillSubCatComponents();
            subCategoryDropdown.Click();
            subCategoryDropdown.SendKeys(subCategory);
            tagsText.SendKeys(tags);
            tagsText.SendKeys(Keys.Enter);
            skillExchangeText.Click();
            skillExchangeText.SendKeys(skillExchange);
            skillExchangeText.SendKeys(Keys.Enter);
            renderShareSkillSaveButtonComponents();
            shareSkillSaveButton.Click();
            Thread.Sleep(1000);
        }

        //NavigateToManageListingPage
        public void NavigateToManageListingPage()
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//a[normalize-space()='Manage Listings']"), 20);
            renderShareSkillmanageListingButtonComponents();
            manageListingButton.Click();
            Thread.Sleep(1000);
        }

        //ListingUpdateOnTheListingDetailPage
        public void ListingUpdateOnTheListingDetailPage(string title, string description)
        {
            Wait.WaitToBeClickable(driver1, By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[2]/i[1]"), 20);
            renderShareSkillSeeComponents();
            seeButton.Click();
            Thread.Sleep(1000);
            By locator = By.XPath("//span[@class='skill-title']");
            pageAssertions.AssertElementTextContainsIWeb(title, locator);

        }

        //ClickOnSeeListing
        public void ClickOnSeeListing(string title)
        {
            Wait.WaitToBeClickable(driver1, By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[2]/i[1]"), 20);
            renderShareSkillSeeComponents();
            seeButton.Click();
            Thread.Sleep(1000);
        }

        //ShowTheListingOnTheListingDetailPage
        public void ShowTheListingOnTheListingDetailPage(string title, string description, string Category, string SubCategory, string SkillExchange, string LocationType)
        {
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]"), 20);
            renderShareSkillSkillTitleComponents();
            string skillTitleactualText = ViewSkillTitle.Text.Trim();
            // The static part of the message you expect
            Assert.That(skillTitleactualText.Contains(title), $"Title of element does not match expected.");
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@class='sixteen wide column']//div[1]//div[1]//div[1]//div[2]"), 20);
            string descriptionactualText = DiscriptionTextDetailPage.Text.Trim();
            // The static part of the message you expect
            Assert.That(descriptionactualText.Contains(description), $"Description of element does not match expected.");
            string categoryactualText = categoryText.Text.Trim();
            // The static part of the message you expect
            Assert.That(categoryactualText.Contains(Category), $"category of element does not match expected.");
            string subCategoryactualText = subCategoryText.Text.Trim();
            // The static part of the message you expect
            Assert.That(subCategoryactualText.Contains(SubCategory), $"subCategory of element does not match expected.");
            string skillExchangeactualText = skillExchangeTextDetailPage.Text.Trim();
            // The static part of the message you expect
            Assert.That(skillExchangeactualText.Contains(SkillExchange), $"skillExchange of element does not match expected.");
            string locationactualText = locationText.Text.Trim();
            // The static part of the message you expect
            Assert.That(locationactualText.Contains(LocationType), $"location of element does not match expected.");



        }

        //ClickOnDeactivateListing
        public void ClickOnDeactivateListing()
        {
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div"), 20);
            renderShareSkillDeactivateButtonComponents();
            DeactivateButton.Click();
            Thread.Sleep(1000);
        }

        //ClickOnActivateListing
        public void ClickOnActivateListing()
        {
            Thread.Sleep(3000);
            Wait.WaitToBeClickable(driver1, By.XPath("/html/body/div/div/div/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div"), 20);
            renderShareSkillActivateButtonComponents();
            activateButton.Click();
            Thread.Sleep(1000);
        }

        //ShowServiceHasBeenDeactivated
        public void ShowServiceHasBeenDeactivated()
        {
            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='ns-box-inner']"), 20);
            string expectedactivateCheckStaticPart = "Service has been deactivated";
            By locator = By.XPath("//div[@class='ns-box-inner']");
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);

        }


        //ServiceHasBeenActivated
        public void ServiceHasBeenActivated()
        {
            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='ns-box-inner']"), 20);
            string expectedactivateCheckStaticPart = "Service has been activated";
            By locator = By.XPath("//div[@class='ns-box-inner']");
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);
        }


        //DeleteListing
        public void DeleteListing(string title)
        {
            Wait.ElementIsVisible(driver1, By.XPath("//tbody/tr[1]/td[3]"), 20);
           renderShareSkilldeleteCheckComponents();
            By locator = By.XPath("//tbody/tr[1]/td[3]");
            pageAssertions.AssertElementTextContainsIWeb(title, locator);
            Wait.WaitToBeClickable(driver1, By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[3]"), 20);
            renderShareSkillPopupdeleteButtonComponents();
            deleteButton.Click();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//button[@class='ui icon positive right labeled button']"), 20);
            renderShareSkillYesButtonComponents();
            yesButton.Click();
        }




        //ListingShouldBeDeleteSuccessfully
        public void ListingShouldBeDeleteSuccessfully()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1,By.XPath("//div[@class='ns-box-inner']"), 20);
            string expecteddeleteCheckStaticPart = "has been deleted";
            By locator = By.XPath("//div[@class='ns-box-inner']");
            pageAssertions.AssertElementTextContainsIWeb(expecteddeleteCheckStaticPart, locator);
        }

    }
}
