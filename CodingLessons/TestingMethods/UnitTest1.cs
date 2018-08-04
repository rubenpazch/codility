using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingLessons;

namespace TestingMethods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = BinaryGap.binary_gap(9);
            Assert.AreEqual(2,result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int result = BinaryGap.binary_gap(529);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int result = BinaryGap.binary_gap(15);
            Assert.AreEqual(0, result);
        }
    }
}
