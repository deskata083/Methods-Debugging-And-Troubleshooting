namespace FibonacciNumbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNum(num));
        }
        static int FibonacciNum(int a)
        {
            int m = 0;
            int n = 1;
            int t = 0;
            for (int i = 1; i <=a; i++)
            {
                t = m + n;
                m = n;
                n = t;
            }
            return n;
        }
    }
}
