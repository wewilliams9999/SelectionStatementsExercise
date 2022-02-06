using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 5;
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What's your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch(favSubject)
            {
                case "English":
                    Console.WriteLine("English is awesome!");
                    break;
                case "Math":
                    Console.WriteLine("Math is fantastic!");
                    break;
                case "History":
                    Console.WriteLine("History is fascinating!");
                    break;
                case "Computer Science":
                    Console.WriteLine("Computer Science in interesting!");
                    break;
                case "Astronomy":
                    Console.WriteLine("Astronomy is cool!");
                    break;
                default:
                    Console.WriteLine($"{favSubject} is great!");
                    break;

            }
        }
    }
}
