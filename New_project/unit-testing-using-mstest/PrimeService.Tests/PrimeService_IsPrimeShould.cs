using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeServices;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(8.3101,PrimeService.Parsing("8,3101"),0.01);
        }
    }
}