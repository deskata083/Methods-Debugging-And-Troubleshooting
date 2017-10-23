using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            ulong first = ulong.Parse(Console.ReadLine());
            ulong second = ulong.Parse(Console.ReadLine());

            List<ulong> list = new List<ulong>();

            for (ulong i = first; i <= second; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            for (int i = 0; i < list.Count-1; i++)
            {
                Console.Write($"{list[i]}, ");
            }
            Console.WriteLine(list[list.Count-1]);
        }
        static bool IsPrime(ulong a)
        {
            bool prime = a > 1;
            ulong b = (ulong)Math.Sqrt(a);
            for (ulong j = 2; j <= b; j++)
            {
                if (a % j == 0)
                {
                    prime = false;
                }
            }
            return prime;
        }
    }
}
