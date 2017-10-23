namespace HelloName
{
    using System;
    public class Program
    {
        static void PrintHello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        public static void Main()
        {
            string newName = Console.ReadLine();
            PrintHello(newName);
        }
    }
}
