using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAppLib;
namespace TestAppLib.Test
{
    [TestClass]
    public class TestclsTest
    {
        [TestMethod]
        public void Student_Sitting_Success_DevidBy3_and_EvenNumber()
        {
            Testcls objcls = new Testcls();
            int n = 12;
            string ExpectedResult = "M P C M P C \rP C M P C M \r";
            string res = objcls.Student_Sitting(n);

            Assert.AreEqual(ExpectedResult, res);
            
        }

        [TestMethod]
        public void Student_Sitting_Success_OddNumber()
        {
            Testcls objcls = new Testcls();
            int n = 7;
            string ExpectedResult = "M P C M \rP C M \r";
            string res = objcls.Student_Sitting(n);

            Assert.AreEqual(ExpectedResult, res);
            
        }
    }
}
