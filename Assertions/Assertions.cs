using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Assertions
{
    public class Assertions
    {
        private readonly IWebDriver driver;

        public Assertions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AssertElementTextContains(string expectedText, By locator)
        {
            var element = driver.FindElement(locator);
            string actualText = element.Text.Trim();
            Assert.That(actualText, Does.Contain(expectedText), $"Error: The actual text '{actualText}' does not contain the expected text '{expectedText}'.");
        }

        public void AssertElementTextContainsIWeb(string expectedText, By locator) //By
        {
            IWebElement element = driver.FindElement(locator);
            string actualText = element.Text.Trim();
            Assert.That(actualText.Contains(expectedText), $"Error: The actual text '{actualText}' does not contain the expected text '{expectedText}'.");
        }

        
    }
}

