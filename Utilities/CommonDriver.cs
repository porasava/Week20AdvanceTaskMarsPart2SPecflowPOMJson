using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week20AdvanceTaskMarsPart2SPecflowPOMJson.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver CreateNewDriver()
        {

            ChromeOptions options = new ChromeOptions();

            // Set window size to 90% of the screen size
            options.AddArgument("force-device-scale-factor=1");

            return new ChromeDriver(options);
        }

        public static void CloseDriver(IWebDriver driver1)
        {
            if (driver1 != null)
            {
                driver1.Quit();
                driver1 = null;
            }
        }

    }


}
