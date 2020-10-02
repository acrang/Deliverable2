using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess which will have more: heads or tails?");
            string headsOrTailsGuess = Console.ReadLine();

            if ((headsOrTailsGuess == "heads" || headsOrTailsGuess == "Heads" || headsOrTailsGuess == "HEADS" || headsOrTailsGuess == "tails" || headsOrTailsGuess == "Tails" || headsOrTailsGuess == "TAILS"))

            {
                Console.WriteLine("How many times shall we flip a coin?");
                string numInput = Console.ReadLine();
                int numberOfFlips = int.Parse(numInput);
                int correctCount = 0;
                int loopCount = 1;
                int flipResult;
                var random = new Random();
               
                    while (loopCount <= numberOfFlips)
                {
                    loopCount = loopCount + 1;
                    flipResult = ((random.Next(2)));
                    if (flipResult == 1)
                    {
                        Console.WriteLine("Heads");
                        if ((headsOrTailsGuess == "heads" || headsOrTailsGuess == "Heads" || headsOrTailsGuess == "HEADS"))
                        {
                            correctCount = correctCount + 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Tails");
                        if ((headsOrTailsGuess == "tails" || headsOrTailsGuess == "Tails" || headsOrTailsGuess == "TAILS"))
                        {
                            correctCount = correctCount + 1;
                        }
                    }

                }   Console.WriteLine("Your guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s).");
                Console.WriteLine("That's " + ((double)correctCount / numberOfFlips * 100) + "%.");
                    
            }else Console.WriteLine("Error. Please select either 'heads' or 'tails'");
        }
    }
}
