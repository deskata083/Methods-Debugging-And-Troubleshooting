namespace Geometrycalculator
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string figure = Console.ReadLine();
            FigureArea(figure);
        }
        static void FigureArea(string name)
        {

            double result = 0;

            switch (name)
            {
                case "triangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        result = side * height / 2;
                        break;
                    }
                case "square":
                    {
                        double side = double.Parse(Console.ReadLine());
                        result = side * side;
                        break;
                    }
                case "rectangle":
                    {
                        double a = double.Parse(Console.ReadLine());
                        double b = double.Parse(Console.ReadLine());
                        result = a * b;
                        break;
                    }
                case "circle":
                    {
                        double r = double.Parse(Console.ReadLine());
                        result = Math.PI * r * r;
                        break;
                    }
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
