using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Triangle2
{
    [TestFixture]
    class Testclass
    {
        Triangle second = new Triangle();
        [Test]
        public void Test_c_minus_returnfalse()
        {     
            Assert.AreEqual(false, second.test(5,3,-5));
        }

        [Test]
        public void test_c_minus_b_minus_a_null_return_false()
        {
            Assert.AreEqual(false, second.test(0,-3,-5));
        }

        [Test]
        public void test_a_null_return_false()
        {
            Assert.AreEqual(false, second.test(0, 3, 5));
        }

        [Test]
        public void test_a_null_b_null_c_null_return_false()
        {
            Assert.AreEqual(false, second.test(0, 0, 0));
        }

        [Test]
        public void test_a_plus_b_more_c_return_true()
        {
            Assert.AreEqual(true, second.test(5, 5, 1));
        }

        [Test]
        public void test_c_more_then_a_plus_b_return_false()
        {
            Assert.AreEqual(false, second.test(5, 5, 11));
        }

        [Test]
        public void test_a_equally_b_equally_c_return_true()
        {
            Assert.AreEqual(true, second.test(5, 5, 5));
        }

        [Test]
        public void Test_b_minus_return_false()
        {
            Assert.AreEqual(false, second.test(5, -6, 5));
        }

        [Test]
        public void test_c_minus_b_minus_a_minus_return_false()
        {
            Assert.AreEqual(false, second.test(-5, -3, -5));
        }

        [Test]
        public void Test_a_minus_returnfalse()
        {
            Assert.AreEqual(false, second.test(-5, 3, 5));
        }
    }
}
