namespace Leetcode
{
    public class ReverseNumber
    {
        public int Reverse(int x)
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

        public int Reverse2(int x)
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

        public int Reverse3(int x)
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

        public int ReverseFastest(int x)
        {
            return x < 0 ? -ConvertFastest(-x + "") : ConvertFastest(x + "");
        }

        public int ConvertFastest(string s)
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

        bool WillOverflow(int x, int factor)
        {
            return x * factor / factor != x;
        }

        int Convert(string s)
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

        int BackConvert(string s)
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

        int IntLength(int n)
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
