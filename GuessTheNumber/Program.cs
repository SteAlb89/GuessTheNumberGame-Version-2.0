using System;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Scrie un program care cere de la user sa ghiceasca un numar si afiseaza urmatoarele:
            // Daca numarul ghicit este mai mare decat 4 afiseaza mai putin
            // Daca numarul ghicit este mai mic decat 4 afiseaza mai mult
            // Daca numarul ghicit este 4 afiseaza bravo ai ghicit
            // TODO: Update1 - Sa se afiseze la finalul programului din cate incercari s-a ghicit numarul
            // TODO: Update2 - Intreaba jucatorul daca vrea sa repete jocul 
            // TODO: Update3 - Stabileste un numar maxim de vieti

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
                    Console.WriteLine("Game Over"); // scris cu rosu 
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                }

                if (guessedNumber > hiddenNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Less"); // Scris cu galben
                    lives--;
                }
                else if (guessedNumber < hiddenNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("More"); // Scris cu galben
                    lives--;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Guessed!\nYou finished the game using {attempts} attempts"); // scris cu verde
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                }
            }
        }
    }
}
