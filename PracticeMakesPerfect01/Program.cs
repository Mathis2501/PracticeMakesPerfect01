using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Source;

namespace PracticeMakesPerfect01
{
    class Program
    {

        static void Main(string[] args)
        {
            IntComparator intComparator = new IntComparator();
            CharComparator charComparator = new CharComparator();
            CustomMath math = new CustomMath();
            Random random = new Random();

            Console.WriteLine(intComparator.GetBiggestInt(1, 2, 3));
            Console.WriteLine(charComparator.GetBiggestChar('a', 'b'));
            Console.WriteLine(math.Modulus(41, 20));
            Console.WriteLine(charComparator.GetNumberOfOcurrences('a', "this is a very understanding string that holds no grudges"));

            Console.WriteLine("Guess the Number");
            string playerGuess;
            int number = random.Next(101);
            bool running = true;
            int i = 0;
            while (running)
            {
                int triesLeft = 7 - i;
                if (triesLeft == 1)
                {
                    Console.WriteLine("You have: " + triesLeft + " try left");
                    
                }
                else
                {
                    Console.WriteLine("You have: " + triesLeft + " tries left");
                }

                playerGuess = Console.ReadLine();
                
                int a;
                if (int.TryParse(playerGuess, out a))
                {
                    if (a.CompareTo(number) == 0)
                    {
                        Console.WriteLine("You won!, good for you.");
                        running = false;
                    }
                    else if (a.CompareTo(number) > 0)
                    {
                        Console.WriteLine("You're to high");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("you're to low");
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("Use numbers Doofus");
                    i++;
                }
                if (triesLeft == 1)
                {
                    running = false;
                }
            }

            Console.WriteLine(charComparator.GetIllegalChars("asadnaiusfq398gh9/H(/#TBWI/#GWF/S&V/SE&EH)A(#"));

            Console.ReadKey();
        }
    }
}
