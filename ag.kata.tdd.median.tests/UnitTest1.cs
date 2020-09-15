using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ag.kata.tdd.median.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new int[] { 1, 2, 3 };

            Assert.AreEqual(2, sut.Median());
        }
    }
}
