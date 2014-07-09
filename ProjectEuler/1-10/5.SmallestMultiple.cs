
namespace ProjectEuler
{
    public class SmallestMultiple
    {
        public static int Run()
        {
            bool b = false;
            int c = 0;
            while (!b)
            {
                c++;
                for (int i = 1; i <= 20; i++)
                {
                    if (c%i != 0)
                        break;
                    if (i == 20)
                        b = true;
                }
            }
            return c;
        }
    }
}
