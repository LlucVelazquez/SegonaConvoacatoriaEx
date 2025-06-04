namespace Ex23
{
    [TestClass]
    public class UtilitatsTests
    {
        [TestMethod]
        public void IsEven_ReturnsTrue_ForEvenNumber()
        {
            Assert.IsTrue(Class.IsEven(2));
            Assert.IsTrue(Class.IsEven(0));
            Assert.IsTrue(Class.IsEven(-4));
        }

        [TestMethod]
        public void IsEven_ReturnsFalse_ForOddNumber()
        {
            Assert.IsFalse(Class.IsEven(1));
            Assert.IsFalse(Class.IsEven(-3));
            Assert.IsFalse(Class.IsEven(99));
        }
    }
}
