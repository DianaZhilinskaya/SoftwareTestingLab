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
        private const string errorMess = "Количество младенцев должно быть меньше или, по крайней мере, равно количеству взрослых пассажиров.";
        
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
            Assert.AreEqual(errorMess, steps.SelectBabyMoreThenOneForOneAdult());
        }
    }
}
