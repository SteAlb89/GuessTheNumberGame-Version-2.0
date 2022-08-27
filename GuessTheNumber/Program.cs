using System;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks the user to guess a number and displays the following:
            // If the guessed number is greater than 4, display less
            // If the guessed number is less than 4, display more
            // If the guessed number is 4, it displays congrats you guessed
            // TODO: Update1 - Display at the end of the program how many attempts the number was guessed from
            // TODO: Update2 - Ask the player if he wants to repeat the game
            // TODO: Update3 - Set a maximum number of lives

            int lives = 7;
            int attempts = 0;
            Random rnd = new Random();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(">>>>>>> Welcome to the Guess The Number Game! <<<<<<<");
            int hiddenNumber = rnd.Next(101);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Guess the number: ");
                int guessedNumber = int.Parse(Console.ReadLine());
                attempts++;

                if (lives == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Game Over"); // To be written in Darkred
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                }

                if (guessedNumber > hiddenNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Less"); // To be written in Darkyellow
                    lives--;
                }
                else if (guessedNumber < hiddenNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("More"); // To be written in Darkyellow
                    lives--;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Guessed!\nYou finished the game using {attempts} attempts"); // To be written in Darkgreen
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                }
            }
        }
    }
}
