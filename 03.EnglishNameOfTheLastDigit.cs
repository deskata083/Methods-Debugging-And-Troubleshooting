namespace EnglishNameOfTheLastDigit
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            PrintName(number);
        }
        static void PrintName (string engl)
        {
            string result = "";
            //string[] digit = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
           string res = "";
           for (int i = engl.Length-1; i >engl.Length-2; i--)
               {
                   result += engl[i].ToString();
                   
               }
            //return digit[result];
            switch (result)
            {
                case "0":
                    {
                        res = "zero";
                        break;
                    }
                case "1":
                    {
                        res = "one";
                        break;
                    }
                case "2":
                    {
                        res = "two";
                        break;
                    }
                case "3":
                    {
                        res = "three";
                        break;
                    }
                case "4":
                    {
                        res = "four";
                        break;
                    }
                case "5":
                    {
                        res = "five";
                        break;
                    }
                case "6":
                    {
                        res = "six";
                        break;
                    }
                case "7":
                    {
                        res = "seven";
                        break;
                    }
                case "8":
                    {
                        res = "eight";
                        break;
                    }
                case "9":
                    {
                        res = "nine";
                        break;
                    }
            
            }
            Console.WriteLine(res);
        }
    }
}
