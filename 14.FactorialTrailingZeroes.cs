namespace FactorialTrailingZeroes
{
    using System;
    using System.Numerics;
    public class StartUp
    {
        public static void Main()
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeros(num));
        }
        static BigInteger Factorial(BigInteger a)
        {
            BigInteger result = 1;
            for (BigInteger i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
        static BigInteger TrailingZeros(BigInteger a)
        {
            int sum = 0;
            string number = Factorial(a).ToString();
            for (int i = number.Length-1; i > 0; i--)
            {
                if (number[i] != '0')
                {
                    break;
                }
                else sum++;
            }
            return sum;
        }
    }
}
