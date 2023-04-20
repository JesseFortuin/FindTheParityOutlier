using FindTheParityOutlier.BL;

namespace FindTheParityOutlier.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 }, 11)]
        [InlineData(new int[] { 160, 3, 1719, 19, 11, 13, -21 }, 160)]
        public void Test1(int[] input, int expected)
        {
            //arrange
            IOutlierFinder finder = new OutlierFinder();

            //act
            int actual = finder.Find(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}