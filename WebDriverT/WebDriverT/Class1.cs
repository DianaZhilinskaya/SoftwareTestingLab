using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace WebDriverT
{
    [TestFixture]
    public class WebDriverTest
    {

        string destinationA = "select2-destinationAirport-containe";
        string departureA = "select2-departureAirport-container";
        string valueA = "Минск";
        string notequal = "destinationAirport--not-equal-to";
        string texterror = "Аэропорты отправления и прибытия не должны совпадать";

        [Test]
        public void message_appears_if_airports_match()
        {
            RemoteWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Navigate().GoToUrl("https://www.lot.com/by/ru");

            var txtFirstAirport = driver.FindElementById(destinationA);
            var txtSecondAirport = driver.FindElementById(departureA);

            txtFirstAirport.Clear();
            txtFirstAirport.SendKeys(valueA);

            txtSecondAirport.Clear();
            txtSecondAirport.SendKeys(valueA);

            var error = driver.FindElementById(notequal);

            Assert.AreEqual(texterror, error.Text);
        }
    }
}
