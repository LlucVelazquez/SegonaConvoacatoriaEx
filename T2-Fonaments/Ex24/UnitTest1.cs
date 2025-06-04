namespace Ex24
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(-3)]
        [InlineData(99)]
        public void IsOdd_ReturnsTrue_ForOddNumbers(int value)
        {
            Assert.True(Class.IsOdd(value));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(-4)]
        public void IsOdd_ReturnsFalse_ForEvenNumbers(int value)
        {
            Assert.False(Class.IsOdd(value));
        }
    }
}