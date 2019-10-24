using System;
using System.Text;
using System.Collections.Generic;
using static System.Console;

namespace diamond
{
    class Program
    {
        public const char SPACE = ' ';
        public const char ASTERISK = '*';

        static void Main(string[] args)
        {
            print(101);
        }

        public static string print(int n)
        {

            StringBuilder sb = new StringBuilder();
            if (!isValid(n))
            {
                return null;
            }

            DrawDiamond(ref sb, n, 0);
            WriteLine(sb.ToString());
            return sb.ToString();
        }

        public static void DrawDiamond(ref StringBuilder sb, int n, int v)
        {
            int spaces = n / 2;
            for (int i = 1; i < n; i += 2)
            {
                sb.Append(string.Format("{0}{1}\n", DrawCharNTimes(SPACE, spaces--), DrawCharNTimes(ASTERISK, i)));
            }
            sb.Append(string.Format("{0}\n", DrawCharNTimes(ASTERISK, n)));

            int diamonds = n - 2;
            for (int i = 1; i <= n / 2; i++)
            {
                sb.Append(string.Format("{0}{1}\n", DrawCharNTimes(SPACE, i), DrawCharNTimes(ASTERISK, diamonds)));
                diamonds = diamonds - 2;
            }
        }
        public static bool isValid(int n)
        {
            return n > 0 && n % 2 != 0;
        }

        public static string DrawCharNTimes(char charToDraw, int timesToRepeat)
        {
            return new string(charToDraw, timesToRepeat);
        }
    }

    public class Diamond
    {
        public static string print(int n)
        {
            if (n % 2 == 0 || n < 0)
            {
                return null;
            }

            int middle = n / 2;
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < n; index++)
            {
                sb.Append(' ', Math.Abs(middle - index));
                sb.Append('*', n - Math.Abs(middle - index) * 2);
                sb.Append("\n");
            }

            return sb.ToString();
        }

    }
}
