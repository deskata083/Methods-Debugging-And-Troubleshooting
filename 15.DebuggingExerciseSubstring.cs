namespace DebuggingExerciseSubstring
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;
                    int endIndex = jump;
                    string matched = "";

                    if (i + endIndex >= text.Length)
                    {
                        matched = text.Substring(i, text.Length - i);
                    }
                    else
                    {
                        matched = text.Substring(i, endIndex + 1);
                    }
                    Console.WriteLine(matched);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
