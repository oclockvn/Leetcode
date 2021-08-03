namespace Leetcode
{
    public static class TestNumber
    {
        public static bool IsPalindrome(int x)
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

        public static int Reverse(int x)
        {
            var neg = x < 0;
            if (neg) x *= -1;

            var s = "";

            while (x > 0)
            {
                s += x % 10;
                x /= 10;
            }

            return int.TryParse(s, out x) ? (neg ? -x : x) : 0;
        }

        public static int Reverse2(int x)
        {
            var neg = x < 0;
            if (neg) x *= -1;

            var s = 0;

            while (x > 0)
            {
                if (s > 214748364 && WillOverflow(s, 10)) // 214748364 = int.MaxValue / 10
                {
                    return 0;
                }

                s = s * 10 + x % 10;
                x /= 10;
            }

            return neg ? -s : s;
        }

        public static int Reverse3(int x)
        {
            var neg = x < 0;
            if (neg) x *= -1;

            var s = "";

            while (x > 0)
            {
                s += x % 10;
                x /= 10;
            }

            return neg ? -Convert(s) : Convert(s);
        }

        public static int ReverseFastest(int x)
        {
            return x < 0 ? -ConvertFastest(-x + "") : ConvertFastest(x + "");
        }

        public static int ConvertFastest(string s)
        {
            int y = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (y > 214748364)
                {
                    return 0;
                }

                y = y * 10 + (s[i] - '0');
            }

            return y;
        }

        public static bool WillOverflow(int x, int factor)
        {
            return x * factor / factor != x;
        }

        public static int Convert(string s)
        {
            int y = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (y > 214748364 && WillOverflow(y, 10))
                {
                    return 0;
                }

                y = y * 10 + (s[i] - '0');
            }

            return y;
        }

        public static int BackwardConvert(string s)
        {
            int y = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (y > 214748364 && WillOverflow(y, 10))
                {
                    return 0;
                }

                y = y * 10 + (s[i] - '0');
            }

            return y;
        }

        public static int IntLength(int n)
        {
            if (n < 10) return 1;
            if (n < 100) return 2;
            if (n < 1000) return 3;
            if (n < 10000) return 4;
            if (n < 100000) return 5;
            if (n < 1000000) return 6;
            if (n < 10000000) return 7;
            if (n < 100000000) return 8;
            if (n < 1000000000) return 9;
            return 10;
        }
    }
}
