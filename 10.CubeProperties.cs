namespace CubeProperties
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string problem = Console.ReadLine();
            PrintResult(problem, side);
        }
        static void PrintResult(string name, double a)
        {

            double result = 0;

            switch (name)
            {
                case "face":
                    {
                        result = a * Math.Sqrt(2);
                        break;
                    }
                case "space":
                    {
                        result = a * Math.Sqrt(3);
                        break;
                    }
                case "volume":
                    {
                        result = a * a * a;
                        break;
                    }
                case "area":
                    {
                        result = a * a * 6;
                        break;
                    }
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
