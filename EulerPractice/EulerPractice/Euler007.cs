namespace EulerPractice
{
    public static class Euler007
    {
        public static long GetAnswer(int input)
        {
            long num = 5;
            var count = 2; 

            while (count < input)
            {
                if (IsPrime(num))
                {
                    count++;
                    Console.WriteLine(count);
                }
                num++;
            }

            return num - 1;
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
