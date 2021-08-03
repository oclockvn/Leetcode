using Xunit;

namespace Leetcode.Tests
{
    public class NumberTests
    {
        [Theory]
        [InlineData(1234, false)]
        [InlineData(-1234, false)]
        [InlineData(10, false)]
        [InlineData(121, true)]
        [InlineData(1001, true)]
        [InlineData(1022112201, true)]
        public void Palindrome_ShouldBeOk(int input, bool expected)
        {
            Assert.Equal(expected, TestNumber.IsPalindrome(input));
        }

        [Theory]
        [InlineData(1234, 4321)]
        [InlineData(-1234, -4321)]
        [InlineData(-1230, -321)]
        [InlineData(123456789, 987654321)]
        [InlineData(1234567899, 0)]
        public void Reverse_ShouldBeOk(int input, int expected)
        {
            Assert.Equal(expected, TestNumber.Reverse(input));
        }

        [Theory]
        [InlineData(1234, 4321)]
        [InlineData(-1234, -4321)]
        [InlineData(-1230, -321)]
        [InlineData(123456789, 987654321)]
        [InlineData(1234567899, 0)]
        public void Reverse2_ShouldBeOk(int input, int expected)
        {
            Assert.Equal(expected, TestNumber.Reverse2(input));
        }

        [Theory]
        [InlineData(1234, 4321)]
        [InlineData(-1234, -4321)]
        [InlineData(-1230, -321)]
        [InlineData(123456789, 987654321)]
        [InlineData(1234567899, 0)]
        public void Reverse3_ShouldBeOk(int input, int expected)
        {
            Assert.Equal(expected, TestNumber.Reverse3(input));
        }
    }
}
