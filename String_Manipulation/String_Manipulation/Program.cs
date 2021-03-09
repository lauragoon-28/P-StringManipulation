using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine($"{quote}");

            Console.WriteLine("What word do you want to look for in the sentence above?");
            string searchWord = Console.ReadLine();

            Console.WriteLine("What word would you like to change it to?");
            string changeWord = Console.ReadLine();

            if (!quote.Contains(searchWord))
            {
                Console.WriteLine($"Sorry, I could not find your word {searchWord}");
                // string reverseWord = string.empty
                char[] charArray = searchWord.ToCharArray();
                for (int i = charArray.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{charArray[i]}");
                    //reverseWord = reverseWord + searchWord[i];
                }
                // console.writeline(reverseWord)
                Console.WriteLine();
            }
            else
            {
                string newQuote = quote.Replace(searchWord, changeWord);
                Console.WriteLine($"{newQuote}");
            }


        }
    }
}
