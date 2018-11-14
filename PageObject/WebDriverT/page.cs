using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Security.Policy;
using System.Threading;

namespace WebDriverT
{
    class Testclass
    {
        public IWebDriver driver;
        string valueD1 = "05.11.2018";
        string notFind = "Выберите дату прибытия";

        [Test]
        public void page()
        {
            driver.Navigate().GoToUrl("https://www.lot.com/by/ru");
            PageHome pageHome = new PageHome(); // чтобы могли обращаться к объектам из PageHome.cs
            PageFactory.InitElements(driver, pageHome); // инициализация элементов Page Object из PageHome.cs
            pageHome.date1.SendKeys(valueD1); // вводим поисковую фразу
            pageHome.findButton.Click();

            Assert.AreEqual(notFind, pageHome.errorMes.Text);

        }
    }
}

