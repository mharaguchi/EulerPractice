namespace EulerPractice
{
    public static class Euler003
    {
        public static long GetAnswer(long input)
        {
            for(int i = 2; i < input / 2; i++)
            {
                if (input % i == 0)
                {
                    var otherFactor = input / i;
                    if (IsPrime(otherFactor))
                    {
                        return otherFactor;
                    }
                }
            }
            return -1;
        }

        public static bool IsPrime(long input)
        {
            for(int i = 2; i < input / 2; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
