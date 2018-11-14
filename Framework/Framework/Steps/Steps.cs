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
    class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Framework.Instance.GetInstance();
        }

        public void CloseBrowser()
        {
            Framework.Instance.CloseBrowser();
        }

        public void SelectPage()
        {
            Framework.PageHome selectPage = new Framework.PageHome(driver);
            selectPage.OpenPage();
            selectPage.SelectMoreThenOneBaby();
        }

        public string SelectBabyMoreThenOneForOneAdult()
        {
            Framework.PageHome mainPage = new Framework.PageHome(driver);
            return mainPage.GetErrorMes();
        }
    }
}

