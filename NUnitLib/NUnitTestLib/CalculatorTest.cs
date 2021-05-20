using System;
using NUnit.Framework;
using NUnitLib;

namespace NUnitTestLib
{
    public class CalculatorTest
    {
        Calculator calculator;

        /*
        [OneTimeSetUp]      // only once object is created and will be used for every method. run one time only to initialize before executing any test method.
        public void Init()
        {
            calculator = new Calculator();
        }

        [OneTimeTearDown]       // at the end that created object will be destroied. After compelete execution of all test method this method will be initialize.
        public void XYZ()
        {
            calculator = null;
        }
        */

        
        [SetUp]     // executes before every test method.
        public void ABC()
        {
            calculator = new Calculator();
        }

        [TearDown]      // will run after every test method execution is done.
        public void XYZ()
        {
            calculator = null;
        }
        

        [Ignore("Ignore")]      // HAVE TO MARK IT, TELLS THIS CLASS IS TEST LOGIC
        public void Test_Addition_With_Valid_Integer()
        {
            //Calculator calculator = new Calculator();
            int result = calculator.Addition(5,3);
            Assert.AreEqual(8, result);     // Assert.AreEqual(expectedresult, actuallresult)
        }

        [Ignore("Ignore test")]     // it is used to prevent method from participating in test, system will not check this condition.
        public void Test_To_Ignore() { }

        [Ignore("Ignore")]
        public void Test_Subtraction_Argument_Exception()
        {
            //Calculator calculator = new Calculator();

            Assert.Catch<SystemException>(() => calculator.Subtraction(3,5));     // can also work with dervied exception classes of the specified exception.

            //Assert.Throws<SystemException>(() => calculator.Subtraction(3,5));        // only works with specified exception only, else will not work.
        }

        // passing multiple testcases to the method to check.

        
        [TestCase(1,2,3)]
        [TestCase(2,3,5)]
        [TestCase(4,6,10)]
        [TestCase(-1,-2,-3)]
        [Ignore("Ignore")]
        public void Test_Addition_With_Valid_Integer(int first, int second, int expectedResult)
        {
            //Calculator calculator = new Calculator();
            int result = calculator.Addition(first, second);
            Assert.AreEqual(expectedResult, result);     // Assert.AreEqual(expectedresult, actuallresult)
        }

        [Test]
        public void Test_Dividion_With_Valid_Integer()
        {
            decimal result = calculator.division(6,3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Test_Division_With_Negative_Integers()
        {
            Assert.Catch<ArgumentException>(() => calculator.division(-4,2));
        }

        [Test]
        public void Test_Division_With_SecondNo_Zero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.division(4,0));
        }
    }
}
