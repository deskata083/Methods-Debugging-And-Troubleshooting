﻿namespace NumbersInReversedOrder
{
   using System;
   public class StartUp
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(Revers(number));
        }

        public static string Revers (string number)
        {
            string result = "";

            for (int i = number.Length-1; i>=0 ; i--)
            {
                result += number[i];
            }
            return result;
        }
        

        
    }
}
