﻿namespace MasterNumbers
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }     
        static bool IsPalindrome(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length/2; i++)
            {
                if (number[i] != number[number.Length-1-i])
                {
                    return false;
                }
            }

            return true;
        }
        static bool SumOfDigits(int num)
        {
            string number = num.ToString();
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }
            if (sum%7==0)
            {
                return true;
            }
            
            return false;
            
        }
        static bool ContainsEvenDigit(int num)
        {
            string number = num.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                int dig = int.Parse(number[i].ToString());
                if (number[i] % 2 == 0)
                {
                   return true;
                }
            }
            return false;
        }
    }
}
