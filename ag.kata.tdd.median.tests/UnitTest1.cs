using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ag.kata.tdd.median.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 c = new Class1();

            Assert.AreEqual(2, c.Median(new int[] { 1, 2, 3 }));
        }
    }
}
