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
    class PageWorkWithOrders
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "returnDate--required")]
        private IWebElement returnDate;
        public IWebElement ReturnDate { get => returnDate; }

        [FindsBy(How = How.Id, Using = "departureDate--required")]
        private IWebElement departureDatePast;
        public IWebElement DepartureDatePast { get => departureDatePast; }

        [FindsBy(How = How.Id, Using = "departureDate-display")]
        private IWebElement departureDate;
        public IWebElement DepartureDate { get => departureDate; }

        [FindsBy(How = How.Id, Using = "VAB__flight__rates__rate__header__content_-1-ECONOMY")]
        private IWebElement selectFlightThere;
        public IWebElement SelectFlightThere { get => selectFlightThere; }

        [FindsBy(How = How.Id, Using = "VAB__flight__rates__rate__header__content_-2-1-ECONOMY")]
        private IWebElement selectFlightHere;
        public IWebElement SelectFlightHere { get => selectFlightHere; }

        [FindsBy(How = How.Id, Using = "select2-destinationAirport-containe")]
        private IWebElement destinationAirport;
        public IWebElement DestinationAirport { get => destinationAirport; }

        [FindsBy(How = How.Id, Using = "select2-departureAirport-container")]
        private IWebElement departureAirport;
        public IWebElement DepartureAirport { get => departureAirport; }

        [FindsBy(How = How.Id, Using = "ui-state-default ui-state-hover")]
        private IWebElement rightDateOfReturn;
        public IWebElement RightDateOfReturn { get => rightDateOfReturn; }
        
        [FindsBy(How = How.Id, Using = "ui-datepicker-group ui-datepicker-group-last")]
        private IWebElement rightDateOfdeaparture;
        public IWebElement RightDateOfdeaparture { get => rightDateOfdeaparture; }

        [FindsBy(How = How.Id, Using = "destinationAirport--not-equal-to")]
        private IWebElement errorMessAirportOfDepartureAndArrivalNotCoincide;
        public IWebElement ErrorMessAirportOfDepartureAndArrivalNotCoincide { get => errorMessAirportOfDepartureAndArrivalNotCoincide; }

        public PageWorkWithOrders(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void SelectDateOfDepartureAndDateOfReturn()
        {
            departureDate.Click();
            returnDate.Click();
        }

        public string SelectRightDateOfReturn()
        {
            return rightDateOfReturn.GetAttribute("content");
        }

        public void SelectEqualAirportOfDepartureAndReturn(string destAirport, string departAirport)
        {
            destinationAirport.SendKeys(destAirport);
            departureAirport.SendKeys(departAirport);
        }

        public string ErrorMessAboutNotEqualAirportOfDepartureAndReturn()
        {
            return errorMessAirportOfDepartureAndArrivalNotCoincide.GetAttribute("content");
        }

        public void SelectPastDateOfDepartureAndReturn()
        {
            departureDatePast.Click();
            returnDate.Click();
        }

        public string SelectRightDateOfReturnAndDeparture()
        {
            return rightDateOfdeaparture.GetAttribute("content");
        }
    }
}
