namespace EulerPractice
{
    public static class Euler006
    {
        public static long GetAnswer(int input)
        {
            var sumSquares = SumSquares(input);
            var sum = Enumerable.Range(1, input).Sum();
            var squareOfSum = sum * sum;

            var diff = squareOfSum - sumSquares;
            return diff;
        }

        public static long SumSquares(int max)
        {
            var sum = 0;
            for(int i = 1; i <= max; i++)
            {
                sum += i * i;
            }
            return sum;
        }
    }
}
