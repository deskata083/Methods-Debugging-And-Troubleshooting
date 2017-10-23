namespace CenterPoint
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintResult(x1, x2, y1, y2);
        }
        static void PrintResult(double x1, double x2, double y1, double y2)
        {
            double distanceOne = Math.Sqrt(x1 * x1 + y1 * y1);
            double distanceTwo = Math.Sqrt(x2 * x2 + y2 * y2);

            if (distanceOne < distanceTwo)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }

    }

}
