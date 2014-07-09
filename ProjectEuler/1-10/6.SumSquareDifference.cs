
namespace ProjectEuler
{
    public class SumSquareDifference
    {
        public static int Run()
        {
            int b = 0;
            for (int i = 1; i <= 100; i++)
            {
                b += i;
            }
            int a = (b * b);
            for (int i = 1; i <= 100; i++)
            {
                a -= (i * i);
            }
            return a;
        }
    }
}
