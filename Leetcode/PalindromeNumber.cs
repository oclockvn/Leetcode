namespace Leetcode
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            var t = x;
            var i = 0;

            while (x > 0)
            {
                i = i * 10 + x % 10;
                x /= 10;
            }

            return i == t;
        }
    }
}
