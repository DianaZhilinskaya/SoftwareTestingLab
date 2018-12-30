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
using Framework.Pages;

namespace Framework
{
    class PageWorkWithPersons
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

        [FindsBy(How = How.Id, Using = "select2-numOfInstants-result-1kmv-2")]
        private IWebElement errorMessWhenSelectedMoreThanOneBabyForOneAdult;
        public IWebElement ErrorMessWhenSelectedMoreThanOneBabyForOneAdult { get => errorMessWhenSelectedMoreThanOneBabyForOneAdult; }

        [FindsBy(How = How.Id, Using = "select2-numOfYouths-result-1ty5-1")]
        private IWebElement selectSingleYouthPerson;
        public IWebElement SelectSingleYouthPerson { get => selectSingleYouthPerson; }

        [FindsBy(How = How.ClassName, Using = "o-btn submit")]
        public IWebElement findButton;
        public IWebElement FindButton { get => findButton; }

        [FindsBy(How = How.Id, Using = "_shoppingcartportlet_WAR_lotairwaysportlet_cart-btn-submit-tablet")]
        private IWebElement buttonNext;
        public IWebElement ButtonNext { get => buttonNext; }

        [FindsBy(How = How.Id, Using = "_passengerdata_WAR_lotairwaysportlet_person_young_1_date_birth_year")]
        private IWebElement selectYearOfBirth;
        public IWebElement SelectYearofBirth { get => selectYearofBirth; }

        [FindsBy(How = How.Id, Using = "select2-numOfAdults-result-8qsl-3")]
        private IWebElement selecNumOfAdultsPeople;
        public IWebElement SelecNumOfAdultsPeople { get => selecNumOfAdultsPeople; }

        [FindsBy(How = How.Id, Using = "select2-numOfYouths-result-p44q-8")]
        private IWebElement selecNumOfYouthsPeople;
        public IWebElement selecNumOfYouthsPeople { get => selecNumOfYouthsPeople; }

        [FindsBy(How = How.ClassName, Using = "ui-state-default")]
        private IWebElement pastDate;
        public IWebElement PastDate { get => pastDate; }

        [FindsBy(How = How.Id, Using = "numOfAdults--sum-max")]
        private IWebElement errorMaxCountOfPeople;
        public IWebElement ErrorMaxCountOfPeople { get => errorMaxCountOfPeople; }

        [FindsBy(How = How.Id, Using = "select2-numOfAdults-result-zj0r-0")]
        private IWebElement selectZeroPessangers;
        public IWebElement SelectZeroPessangers { get => selectZeroPessangers; }

        [FindsBy(How = How.Id, Using = "numOfAdults--sum-min")]
        private IWebElement errorMinCountOfPeople;
        public IWebElement ErrorMinCountOfPeople { get => errorMinCountOfPeople; }

        [FindsBy(How = How.Id, Using = "_passengerdata_WAR_lotairwaysportlet_passenger1-special-assistanceCheckbox")]
        private IWebElement personNeedSpecialHelp;
        public IWebElement PersonNeedSpecialHelp { get => personNeedSpecialHelp; }

        [FindsBy(How = How.Id, Using = "_passengerdata_WAR_lotairwaysportlet_data_emergencyCheckbox")]
        private IWebElement dataTransferToThirdFace;
        public IWebElement DataTransferToThirdFace { get => dataTransferToThirdFace; }


        public PageWorkWithPersons(IWebDriver driver)
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

        public void IndependentFlightForChildrenUnderTwelveYearsOld()
        {
            PageWorkWithOrders.returnDate.Click();
            PageWorkWithOrders.departureDate.Click();
            selectSingleYouthPerson.Click();
            findButton.Click();
            PageWorkWithOrders.selectFlightThere.Click();
            PageWorkWithOrders.selectFlightHere.Click();
            buttonNext.Click();
            selectYearOfBirth.Click();
        }

        public string GetYearOfBirth()
        {
            return selectYearOfBirth.GetAttribute("content");
        }

        public void ChooseNumberOfPassengers()
        {
            selecNumOfAdultsPeople.Click();
            selecNumOfYouthsPeople.Click();
        }

        public string GetErrorAboutNumberOfPassengers()
        {
            return errorMaxCountOfPeople.GetAttribute("content");
        }

        public void ChooseZeroCountOfPassengers()
        {
            selectZeroPessangers.Click();
        }

        public string GetErrorAboutZeroCountOfPassengers()
        {
            return ErrorMinCountOfPeople.GetAttribute("content");
        }

        public void ChoosePessangerWichNeedSpecialHelp()
        {
            PageWorkWithOrders.returnDate.Click();
            PageWorkWithOrders.departureDate.Click();
            selectSingleYouthPerson.Click();
            findButton.Click();
            PageWorkWithOrders.selectFlightThere.Click();
            PageWorkWithOrders.selectFlightHere.Click();
            buttonNext.Click();
            selectYearOfBirth.Click();
        }

        public string GetPessangerWichNeedSpecialHelp()
        {
            return personNeedSpecialHelp.GetAttribute("content");
        }

        public void ChoosePossibilityToTransferDataToThirdFace()
        {
            PageWorkWithOrders.returnDate.Click();
            PageWorkWithOrders.departureDate.Click();
            selectSingleYouthPerson.Click();
            findButton.Click();
            PageWorkWithOrders.selectFlightThere.Click();
            PageWorkWithOrders.selectFlightHere.Click();
            buttonNext.Click();
            selectYearOfBirth.Click();
        }

        public string GetPossibilityToTransferDataToThirdFace()
        {
            return dataTransferToThirdFace.GetAttribute("content");
        }
    }


}
