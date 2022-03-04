namespace EulerPractice
{
    public static class Euler004
    {
        public static long GetAnswer()
        {
            var largestPalindrome = 0;
            for(int i = 100; i < 1000; i++)
            {
                for(int j = 100; j < 1000; j++)
                {
                    var product = i * j;
                    if (product > largestPalindrome && IsPalindrome(product))
                    {
                        //Console.WriteLine(product);
                        largestPalindrome = product;
                    }
                }
            }
            return largestPalindrome;
        }

        public static bool IsPalindrome(long input)
        {
            var str = input.ToString();
            var reverseCharArray = str.ToCharArray();
            Array.Reverse(reverseCharArray);
            var reverseStr = new string(reverseCharArray);
            if (str == reverseStr)
            {
                return true;
            }
            return false;
        }
    }
}
