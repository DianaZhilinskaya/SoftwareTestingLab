using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Security.Policy;

namespace _10UnitTests
{
    class Driver
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;

        private Driver() { }

        public static IWebDriver GetInstance()
        {
            if (driver == null)
            {
                //driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
                driver = new OpenQA.Selenium.Chrome.ChromeDriver();
                driver.Manage().Window.Size = new System.Drawing.Size(driver.Manage().Window.Size.Width / 2, driver.Manage().Window.Size.Height);
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
                // driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                //driver.Manage().Window.Maximize();
            }
            return driver;
        }
        public static void CloseBrowser()
        {
            driver.Quit();
            driver = null;
        }

    }
}
