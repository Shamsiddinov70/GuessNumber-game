using System;
using System.Linq;

namespace GuessNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Guess a number game!

            Random myRandom = new Random();
            int originNum = myRandom.Next(1, 100);

            int guessNum = 0;
            int guessCount = 0;

            while (guessNum != originNum)
            {
                Console.Write("You should find the answer 1 to 10 attempts.Enter a guess number (numbers between 1 to 100): ");

                guessNum = Convert.ToInt32(Console.ReadLine());

                if (guessNum < originNum)
                {
                    Console.WriteLine($"Number greater than {guessNum}");
                }

                else if (guessNum > originNum)
                {
                    Console.WriteLine($"Number less than {guessNum}");
                }

                guessCount++;
                //Console.WriteLine(guessCount);
                if (guessCount > 10)
                {
                    Console.WriteLine("You are looser! You couldn't find 10 attempts");
                    break;
                }
            }

            Console.WriteLine($"You are winner! You found the answer {guessCount} attempts.");
        }
    }
}