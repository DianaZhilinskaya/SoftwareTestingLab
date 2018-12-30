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
            Framework.PageWorkWithPersons selectPage = new Framework.PageWorkWithPersons(driver);
            selectPage.OpenPage();
            selectPage.SelectMoreThenOneBaby();
        }

        public string SelectBabyMoreThenOneForOneAdult()
        {
            Framework.PageWorkWithPersons mainPage = new Framework.PageWorkWithPersons(driver);
            return mainPage.GetErrorMes();
        }

        public void ChooseYouthPersonLessThenTwelve()
        {
            Framework.PageWorkWithPersons selectPage = new Framework.PageWorkWithPersons(driver);
            selectPage.OpenPage();
            selectPage.IndependentFlightForChildrenUnderTwelveYearsOld();
        }

        public string CanNotCanNotChooseYouthPersonLessThenTwelveYear()
        {
            Framework.PageWorkWithPersons mainPage = new Framework.PageWorkWithPersons(driver);
            return mainPage.GetYearOfBirth();
        }

        public void ChoosePastDateOfReturn()
        {
            Framework.PageWorkWithOrders selectPage = new Framework.PageWorkWithOrders(driver);
            selectPage.SelectDateOfDepartureAndDateOfReturn();
        }

        public string CanNotChoosePastDate()
        {
            Framework.PageWorkWithOrders mainPage = new Framework.PageWorkWithOrders(driver);
            return mainPage.SelectRightDateOfReturn();
        }

        public void ChoosePastDateOfReturnAndDeparure()
        {
            Framework.PageWorkWithOrders selectPage = new Framework.PageWorkWithOrders(driver);
            selectPage.SelectPastDateOfDepartureAndReturn();
        }

        public string CanNotChoosePastDateOfReturnAndDeparure()
        {
            Framework.PageWorkWithOrders mainPage = new Framework.PageWorkWithOrders(driver);
            return mainPage.SelectRightDateOfReturnAndDeparture();
        }

        public void ChooseBigCountOfPessanger()
        {
            Framework.PageWorkWithPersons selectPage = new Framework.PageWorkWithPersons(driver);
            selectPage.ChooseNumberOfPassengers();
        }

        public string CanNotChooseCountOfPessangerMoreThenTen()
        {
            Framework.PageWorkWithPersons mainPage = new Framework.PageWorkWithPersons(driver);
            return mainPage.GetErrorAboutNumberOfPassengers();
        }

        public void ChooseEqualAirportOfDepartureAndReturn()
        {
            Framework.PageWorkWithOrders selectPage = new Framework.PageWorkWithOrders(driver);
            selectPage.SelectEqualAirportOfDepartureAndReturn("Минск",  "Минск");
        }

        public string CanNotChooseEqualAirportOfDepartureAndReturn()
        {
            Framework.PageWorkWithOrders mainPage = new Framework.PageWorkWithOrders(driver);
            return mainPage.ErrorMessAboutNotEqualAirportOfDepartureAndReturn();
        }

        public void ChooseZeroCountOfPeople()
        {
            Framework.PageWorkWithPersons selectPage = new Framework.PageWorkWithPersons(driver);
            selectPage.ChooseZeroCountOfPassengers();
        }

        public string CanNotChooseZeroCountOfPeople()
        {
            Framework.PageWorkWithPersons mainPage = new Framework.PageWorkWithPersons(driver);
            return mainPage.GetErrorAboutZeroCountOfPassengers();
        }

        public void ChoosePersonWichNeedSpecialHelp()
        {
            Framework.PageWorkWithPersons selectPage = new Framework.PageWorkWithPersons(driver);
            selectPage.OpenPage();
            selectPage.ChoosePessangerWichNeedSpecialHelp();
        }

        public string CanChoosePersonWichNeedSpecialHelp()
        {
            Framework.PageWorkWithPersons mainPage = new Framework.PageWorkWithPersons(driver);
            return mainPage.GetPessangerWichNeedSpecialHelp();
        }

        public void SelectPossibilityToTransferDataToThirdFace()
        {
            Framework.PageWorkWithPersons selectPage = new Framework.PageWorkWithPersons(driver);
            selectPage.OpenPage();
            selectPage.ChoosePessangerWichNeedSpecialHelp();
        }

        public string CanChoosePossibilityToTransferDataToThirdFace()
        {
            Framework.PageWorkWithPersons mainPage = new Framework.PageWorkWithPersons(driver);
            return mainPage.GetPessangerWichNeedSpecialHelp();
        }
    }
}

