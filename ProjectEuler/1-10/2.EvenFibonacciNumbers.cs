
using System;

namespace ProjectEuler
{
    public class EvenFibonacciNumbers
    {
        public static int Run(int max)
        {
            int next = 0, first = 1, second = 2, sum = 0;
            while (next <= 4000000)
            {
                next = first + second;
                first = second;
                second = next;
                if (first%2 == 0)
                {
                    sum += first;
                }
            }
            return sum;
        }
    }
}
