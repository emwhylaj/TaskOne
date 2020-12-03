using System;

namespace NumberThreeAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int wordCount = 0;
                Console.WriteLine("---------------------Welcome to the word count app------------------------");
                Console.WriteLine("Input your word of choice");
                string word = Console.ReadLine().ToLower();

                do
                {
                    string.IsNullOrWhiteSpace(word);
                    if (word.Contains("sa"))
                    {
                        Console.WriteLine("The word input contain sa");
                    }
                    else
                    {
                        Console.WriteLine("The word input does not contain sa");
                    }

                    foreach (var i in word)
                    {
                        if (!i.ToString().Equals("e") && !i.ToString().Equals("m"))
                        {
                            wordCount++;
                        }
                    }
                    Console.WriteLine("There are {0} characters that do not include \"e\"  or \"m\" in the word {1}", wordCount, word);
                }
                while

                    (string.IsNullOrWhiteSpace(word));

                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        
    }
}
