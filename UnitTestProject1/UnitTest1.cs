using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 1;
            double b = -5;
            double c = 4;
            double[] expected = { 4, 1 };
            double[] actual = Program.Calc(a, b, c);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
