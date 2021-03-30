using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;

namespace Test
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, 6)]
        [DataRow(4, 24)]
        [DataRow(5, 120)]
        [DataRow(6, 720)]
        public void TestFactorialNumber6(int numb, int expectedResult)
        {
            int factorialNumb = FactorialNumber.GenerateFactorialNumber(number: numb);
            Assert.AreEqual(expectedResult, factorialNumb);
        }
    }
}
