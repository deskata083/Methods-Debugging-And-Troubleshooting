namespace MaxMethod
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());

            int d = Getmax(a1, b1);
            int x = Getmax(c1, d);
            Console.WriteLine(x);
        }
        static int Getmax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }


    }

}
