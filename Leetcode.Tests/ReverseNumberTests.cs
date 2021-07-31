using Xunit;

namespace Leetcode.Tests
{
    public class ReverseNumberTests
    {
        [Theory]
        [InlineData(1234, 4321)]
        [InlineData(-1234, -4321)]
        [InlineData(-1230, -321)]
        [InlineData(123456789, 987654321)]
        [InlineData(1234567899, 0)]
        public void ShouldBeOk(int input, int expected)
        {
            var sut = new ReverseNumber();

            Assert.Equal(expected, sut.Reverse(input));
        }

        [Theory]
        [InlineData(1234, 4321)]
        [InlineData(-1234, -4321)]
        [InlineData(-1230, -321)]
        [InlineData(123456789, 987654321)]
        [InlineData(1234567899, 0)]
        public void ShouldBeOk2(int input, int expected)
        {
            var sut = new ReverseNumber();

            Assert.Equal(expected, sut.Reverse2(input));
        }

        [Theory]
        [InlineData(1234, 4321)]
        [InlineData(-1234, -4321)]
        [InlineData(-1230, -321)]
        [InlineData(123456789, 987654321)]
        [InlineData(1234567899, 0)]
        public void ShouldBeOk3(int input, int expected)
        {
            var sut = new ReverseNumber();

            Assert.Equal(expected, sut.Reverse3(input));
        }
    }
}
