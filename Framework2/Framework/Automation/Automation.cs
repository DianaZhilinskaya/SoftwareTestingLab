using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Framework
{
    [TestFixture]
    class Automation
    {
        private Framework.Steps steps = new Framework.Steps();
        private const string ERRORMESS = "Количество младенцев должно быть меньше или, по крайней мере, равно количеству взрослых пассажиров.";
        private const string YEAR = "2007";
        private const string DATE_RETURN = "10.01.2019";
        private const string DATE_DEPARTURE = "10.01.2019";
        private const string ERROR_MESS_ABOUT_COUNT_OF_PASSENGERS = "Количесвто пассажиров не может превышать 9.";
        private const string ERROR_MESS_ABOUT_AIRPORT = "Аэропорты отправления и прибытия не должны совпадать.";
        private const string ERROR_MESS_ABOUT_MIN_COUNT_OF_PESS = "Требуется, по крайней мере, один взрослый или пожилой человек.";
        private const string MESS_ABOUT_SPECIAL_HELP = "Пассажир требует специальной помощи";
        private const string MESS_ABOUT_THIRD_FACE = "Передача данных третьим лицам";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void ErrorMessWhenMoreThanOneBabyForOneAdult()
        {
            steps.SelectPage();
            Assert.AreEqual(ERRORMESS, steps.SelectBabyMoreThenOneForOneAdult());
        }

        [Test]
        public void CanNotCanNotChooseYouthPersonLessThenTwelve()
        {
            steps.SelectPage();
            Assert.AreEqual(YEAR, steps.CanNotCanNotChooseYouthPersonLessThenTwelveYear());
        }

        [Test]
        public void CanNotChoosePastDayBecauseUnenable()
        {
            steps.SelectPage();
            Assert.AreEqual(DATE_RETURN, steps.CanNotChoosePastDate());
        }

        [Test]
        public void CanNotChooseCountOfPessangerMoreThenTenPeople()
        {
            steps.SelectPage();
            Assert.AreEqual(ERROR_MESS_ABOUT_COUNT_OF_PASSENGERS, steps.CanNotChooseCountOfPessangerMoreThenTen());
        }

        [Test]
        public void CanNotChooseEqualDepartureAndReturnAirport()
        {
            steps.SelectPage();
            Assert.AreEqual(ERROR_MESS_ABOUT_AIRPORT, steps.CanNotChooseEqualAirportOfDepartureAndReturn());
        }

        [Test]
        public void CanNotChoosePastDayOfDepartureBecauseUnenable()
        {
            steps.SelectPage();
            Assert.AreEqual(DATE_DEPARTURE, steps.CanNotChoosePastDate());
        }

        [Test]
        public void CanNotChooseZeroCountOfPeopleBecauseUnenable()
        {
            steps.SelectPage();
            Assert.AreEqual(ERROR_MESS_ABOUT_MIN_COUNT_OF_PESS, steps.CanNotChooseZeroCountOfPeople());
        }

        [Test]
        public void CanChoosePersonWichNeedSpecialHelpEnable()
        {
            steps.SelectPage();
            Assert.AreEqual(MESS_ABOUT_SPECIAL_HELP, steps.CanChoosePersonWichNeedSpecialHelp());
        }

        [Test]
        public void CanChoosePossibilityToTransferDataToThirdFaceEnable()
        {
            steps.SelectPage();
            Assert.AreEqual(MESS_ABOUT_THIRD_FACE, steps.CanChoosePossibilityToTransferDataToThirdFace());
        }
    }
}
