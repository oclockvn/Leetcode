using Xunit;

namespace Leetcode.Tests
{
    public class PalindromeNumberTests
    {
        [Theory]
        [InlineData(1234, false)]
        [InlineData(-1234, false)]
        [InlineData(10, false)]
        [InlineData(121, true)]
        [InlineData(1001, true)]
        [InlineData(1022112201, true)]
        public void ShouldBeOk(int input, bool expected)
        {
            var sut = new PalindromeNumber();

            Assert.Equal(expected, sut.IsPalindrome(input));
        }
    }
}
