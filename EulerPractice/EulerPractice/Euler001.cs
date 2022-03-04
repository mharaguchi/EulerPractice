namespace EulerPractice
{
    public static class Euler001
    {
        public static int GetAnswer(int input)
        {
            var sum = 0;
            for(int i = 0; i < input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
