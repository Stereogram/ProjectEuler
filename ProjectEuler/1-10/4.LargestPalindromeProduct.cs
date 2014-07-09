
using System;
using System.Linq;

namespace ProjectEuler
{
    public class LargestPalindromeProduct
    {

        public static int Run()
        {
            int r = 0;
            for (int i = 100; i <= 1000; i++)
            {
                for (int j = 100; j <= 1000; j++)
                {
                    if (IsPalim(i*j))
                        r = r < i*j ? i*j : r;
                }
            }
            return r;
        }

        private static bool IsPalim(int a)
        {
            return new string(a.ToString().Reverse().ToArray()) == a.ToString();
        }

    }
}
