using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAppLib;
using System.Collections.Generic;
namespace TestAppLib.Test
{
    [TestClass]
    public class TemperatureTest
    {
        [TestMethod]
        public void calculateTemperature_Success()
        {
            List<string> temps = new List<string>()
            { "1, 10000, 40","1,10002,45","1,11015,50","2,10005,42","2,11051,45","2,12064,42","2,13161,42"};
            Temperature objtpr = new Temperature();

            Dictionary<string, string> expectdresult = new Dictionary<string, string>();
            expectdresult.Add("10000-10999", "42.33");
            expectdresult.Add("11000-11999", "47.5");
            expectdresult.Add("12000-12999", "42");
            expectdresult.Add("13000-13999", "42");

            var result=objtpr.calculateTemperature(temps);

            Assert.AreEqual(expectdresult.Count, result.Count);
            
        }
    }
}
