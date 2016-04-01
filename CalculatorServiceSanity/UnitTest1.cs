using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorServiceSanity.Calculator;

namespace CalculatorServiceSanity
{
    [TestClass]
    public class UnitTest1
    {
       static CalculatorClient client;
        [ClassInitialize]
        public static  void initialize(TestContext context)
        {
            client = new CalculatorClient();
        }
        [TestMethod]
        public void AddNumberTest()
        {
           double result= client.AddNumbers(10, 20);
           Assert.AreEqual(30,result);
        }
    }
}
