namespace Factorial
{
    using System;
    using System.Numerics;
    public class StartUp
    {
        public static void Main()
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num)); 
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
      
    }
}