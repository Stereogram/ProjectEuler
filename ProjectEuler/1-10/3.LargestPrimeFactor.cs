
using System;

namespace ProjectEuler
{
    public class LargestPrimeFactor
    {
        public static int Run(int max)
        {
            const int a = 2; //start from 2

            for (int i = a; i <= max; i++)
            {

                for (int j = 2; j <= i; j++)
                {
                    if (i%j == 0 && (i != j)) //Condition for not prime
                    {
                        break;
                    }

                    if (j == i) //condition for Prime Numbers
                    {
                        if (i%600851475143 == 0)
                            return i;
                    }
                }
            }
            return 0;
        }
    }
}
