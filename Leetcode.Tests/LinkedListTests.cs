using Xunit;

namespace Leetcode.Tests
{
    public class LinkedListTests
    {
        [Theory]
        [InlineData(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
        [InlineData(new[] { 2, 4 }, new[] { 5, 6 }, new[] { 7, 0, 1 })]
        [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
        [InlineData(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        [InlineData(new[] { 2, 4, 9 }, new[] { 5, 6, 4, 9 }, new[] { 7, 0, 4, 0, 1 })]
        public void Sum_LinkedList_ShouldBeOk(int[] l1, int[] l2, int[] expected)
        {
            var list1 = new ListNode(l1);
            var list2 = new ListNode(l2);

            var result = new LinkedList().AddTwoNumbers(list1, list2);

            Assert.Equal(expected, result.ToArray());
        }
    }
}
