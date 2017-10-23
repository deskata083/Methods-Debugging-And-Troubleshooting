namespace PrimeChecker
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(number));
        }
        static bool IsPrime(ulong a)
        {
            bool prime = a > 1;
            ulong b = (ulong)Math.Sqrt(a);
            for (ulong i = 2; i <= b; i++)
            {
                if (a % i == 0)
                {
                    prime= false;
                }
            }
            return prime;
        }
    }
}

