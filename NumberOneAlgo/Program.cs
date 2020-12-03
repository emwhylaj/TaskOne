using System;

namespace NumberOneAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                int b = 0;


                Console.WriteLine("Input your desired integer:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input another integer:");
                b = Convert.ToInt32(Console.ReadLine());

                if (a == 30 || a + b == 30)
                {
                    Console.WriteLine("You guessed right");
                }
                else if (a != 30 || a + b != 30)
                {
                    Console.WriteLine("You number you input does not contain 30 or the addition of 30");
                    Console.WriteLine("The sum of the integer is : {0}", a + b);
                }
            }
            catch (Exception message)
            {
                throw message;
            }

        }
    }
    
}
