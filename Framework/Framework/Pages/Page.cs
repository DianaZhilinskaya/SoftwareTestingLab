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

namespace Framework
{
    class PageHome
    {
        private const string URL = "https://www.lot.com/by/ru";
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "passenger-text")]
        private IWebElement selectAmountOfDifferentPassenger;
        public IWebElement SelectAmountOfDifferentPassenger { get => selectAmountOfDifferentPassenger;}
        
        [FindsBy(How = How.Id, Using = "select2-numOfInfants-container")]
        private IWebElement selectAmountOfBaby;
        public IWebElement SelectAmountOfBaby { get => selectAmountOfBaby;}
        
        [FindsBy(How = How.Id, Using = "select2-numOfInstants-result-1kmv-2")]
        private IWebElement selectMoreThenOneBabyForOneAdult;
        public IWebElement SelectMoreThenOneBabyForOneAdult { get => selectMoreThenOneBabyForOneAdult; }
        
        [FindsBy(How = How.Id, Using = "returnDate--required")]
        private IWebElement errorMessWhenSelectedMoreThanOneBabyForOneAdult;
        public IWebElement ErrorMessWhenSelectedMoreThanOneBabyForOneAdult { get => errorMessWhenSelectedMoreThanOneBabyForOneAdult; }
        
        public PageHome(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(URL);
        }
        
        public void SelectMoreThenOneBaby()
        {
            selectAmountOfDifferentPassenger.Click();
            selectAmountOfBaby.Click();
            selectMoreThenOneBabyForOneAdult.Click();
        }

        public string GetErrorMes()
        {
            return errorMessWhenSelectedMoreThanOneBabyForOneAdult.GetAttribute("content");
        }
    }


}
