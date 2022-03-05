namespace EulerPractice
{
    public static class Euler005
    {
        public static long GetAnswer(int input)
        {
            var found = false;
            var candidate = input;
            while (!found)
            {
                found = IsDivisible(candidate, input);
                if (found)
                {
                    return candidate;
                }
                candidate++;
            }
            return -1;
        }

        public static bool IsDivisible(int candidate, int max)
        {
            for(int i = 2; i < max; i++)
            {
                if (candidate % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
