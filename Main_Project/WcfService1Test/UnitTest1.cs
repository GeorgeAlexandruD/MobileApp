using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WcfService1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange 
            /*create*/
            int a = 2;
            int b = 2;
            int? result = null;
            int expectedResult = 4;

            //act
            result = a + b;            

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}