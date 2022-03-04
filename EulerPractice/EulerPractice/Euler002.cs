namespace EulerPractice
{
    public static class Euler002
    {
        public static long GetAnswer(long input)
        {
            var sum = 2;
            var prevNum = 1;
            var thisNum = 2;
            while (thisNum < input)
            {
                var newNum = thisNum + prevNum;
                if (newNum % 2 == 0 && newNum < input)
                {
                    sum += newNum;
                }
                prevNum = thisNum;
                thisNum = newNum;
            }

            return sum;
        }
    }
}
