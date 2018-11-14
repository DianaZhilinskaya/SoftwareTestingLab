using System;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
namespace WebDriverT
{
    class PageHome
    {
        /// <summary>Строка для ввода текста поиска</summary>
        [FindsBy(How = How.Id, Using = "departureDate-display")]
        public IWebElement date1;
        [FindsBy(How = How.ClassName, Using = "o-btn submit")]
        public IWebElement findButton;
        [FindsBy(How = How.Id, Using = "returnDate--required")]
        public IWebElement errorMes;
    }
}
